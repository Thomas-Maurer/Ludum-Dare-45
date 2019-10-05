using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public GameObject parent;
    private EnemyCtrl enemy;
    private CircleCollider2D aggroRange;

    public void generateAggroRange()
    {
        Debug.Log("Create RangeAggro");
        parent = transform.parent.gameObject;
        enemy = parent.GetComponent<EnemyCtrl>();

        aggroRange = GetComponent<CircleCollider2D>();
        aggroRange.radius = (float)(enemy.Enemy.Level * 0.5);
        Debug.Log(aggroRange.radius);

    }

    //When the range is trigger the enemy should go toward the target
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Player detected ");
            enemy.AggroTarget.target = collision.transform;
        }
    }
}

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
        parent = transform.parent.gameObject;
        enemy = parent.GetComponent<EnemyCtrl>();

        aggroRange = GetComponent<CircleCollider2D>();
        aggroRange.radius = (float)(enemy.Enemy.Level * 0.5);
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

    //When the range is trigger the enemy should go toward the target
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player leave aggro range");
        enemy.AggroTarget.target = null;
    }
}

using UnityEngine;
using System.Collections;

public class EnemyController: MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;
    [SerializeField]
    public Enemy enemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    //Follow the target if the enemy has one
    private void FollowTarget()
    {
        if (enemy.Target != null)
        {
            float speed = (float)enemy.Speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, enemy.Target.position, speed);
        }
    }
    //When the range is trigger the enemy should go toward the target
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Player")
        {
            enemy.Target = collision.transform;
        }
    }
}

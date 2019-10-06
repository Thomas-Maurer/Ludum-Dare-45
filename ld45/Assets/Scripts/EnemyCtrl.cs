using Pathfinding;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    protected GameObject prefab;
    private Enemy enemy;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private Transform target;

    private AIDestinationSetter aggroTarget;
    private Animator anim;
    private AIPath pathFindingConfig;
    private Vector2 direction;



    public AIDestinationSetter AggroTarget { get => aggroTarget; set => aggroTarget = value; }
    public AIPath PathFindingConfig { get => pathFindingConfig; set => pathFindingConfig = value; }
    public Enemy Enemy { get => enemy; set => enemy = value; }
    public Vector2 Direction { get => direction; set => direction = value; }

    // Start is called before the first frame update
    void Start()
    {
    }
    public virtual void init(Enemy enemy)
    {
        this.enemy = enemy;
        pathFindingConfig = GetComponent<AIPath>();
        pathFindingConfig.maxSpeed = (float)this.enemy.Speed;
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();

        Range range = GetComponentInChildren<Range>();
        range.generateAggroRange();

        aggroTarget = GetComponent<AIDestinationSetter>();
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        checkDirection();
    }

    void checkDirection()
    {
        if(aggroTarget.target != null && !anim.GetBool("followTarget"))
        {
            anim.SetBool("followTarget",true);
        }

        Vector2 heading = (aggroTarget.target.transform.position - transform.position).normalized;
        anim.SetFloat("xInput", heading.x);
        anim.SetFloat("yInput", heading.y);
        
        
    }
}

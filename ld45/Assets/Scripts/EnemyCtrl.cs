﻿using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    protected GameObject prefab;
    private Enemy enemy;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private Transform target;

    private AIDestinationSetter aggroTarget;
    private AIPath pathFindingConfig;
    public Transform Target { get => target; set => target = value; }

    public AIDestinationSetter AggroTarget { get => aggroTarget; set => aggroTarget = value; }
    public AIPath PathFindingConfig { get => pathFindingConfig; set => pathFindingConfig = value; }
    public Enemy Enemy { get => enemy; set => enemy = value; }

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
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
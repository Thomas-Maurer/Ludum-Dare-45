using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int level;
    private int hp;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private Transform target;
    private double speed;
    public Transform Target { get => target; set => target = value; }
    public double Speed { get => speed; set => speed = value; }

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
        
        this.level = this.generateLevel();
        Debug.Log("Hello: " + this.level);
        this.hp = this.generateHp();
        this.Speed = this.generateSpeed();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Generate the level of the Enemy
    int generateLevel()
    {
        return NumbersUtils.RandomNumber(1, 69);
    }
    //Generate HP by level.
    //Maths formula = level * 3
    int generateHp()
    {
        return this.level * 3;
    }

    //Generate Speed by level.
    //Maths formula = level * 0.1
    double generateSpeed()
    {
        return this.level * 0.05;
    }

}

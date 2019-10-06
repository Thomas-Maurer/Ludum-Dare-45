using System;
using UnityEngine;

public class Enemy
{
    protected int level;
    protected int hp;
    protected double speed;
    public double Speed { get => speed; set => speed = value; }
    public int Level { get => level; set => level = value; }

    public Enemy()
	{
        this.level = this.generateLevel();
        Debug.Log("level of Enemy is " + this.level);
        this.hp = this.generateHp();
        this.Speed = this.generateSpeed();

    }

    // Generate the level of the Enemy
    protected virtual int generateLevel()
    {
        return NumbersUtils.RandomNumber(50, 69);
    }
    //Generate HP by level.
    //Maths formula = level * 3
    protected virtual int generateHp()
    {
        return this.level * 3;
    }

    //Generate Speed by level.
    //Maths formula = level * 0.2
    protected virtual double generateSpeed()
    {
        this.speed = this.level * 0.02;
        return this.speed;
    }

}

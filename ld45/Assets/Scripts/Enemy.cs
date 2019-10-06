using System;
using UnityEngine;

public class Enemy
{
    protected int level;
    private int hp;
    protected double speed;
    private int coinRewarded;
    private int damage;
    private int diceNumber;
    public double Speed { get => speed; set => speed = value; }
    public int Level { get => level; set => level = value; }
    public int CoinRewarded { get => coinRewarded; set => coinRewarded = value; }
    public int Damage { get => damage; set => damage = value; }
    public int Hp { get => hp; set => hp = value; }
    public int DiceNumber { get => diceNumber; set => diceNumber = value; }

    public Enemy()
	{
        this.level = this.generateLevel();
        Debug.Log("level of Enemy is " + this.level);
        this.hp = this.generateHp();
        this.Speed = this.generateSpeed();
        this.CoinRewarded = this.generateCoinRewarded();
        this.Damage = this.generateDamage();
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

    //Generate coin rewarded by level.
    //Maths formula = cReward * 2
    protected virtual int generateCoinRewarded()
    {
        coinRewarded = this.level * 2;
        return coinRewarded;
    }

    //Generate damage by level.
    //Maths formula = damage * 2
    protected virtual int generateDamage()
    {
        Damage = Level * 2;
        return Damage;
    }

}

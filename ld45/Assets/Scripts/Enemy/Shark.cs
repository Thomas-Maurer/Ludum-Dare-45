using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : Enemy
{
    public Shark(): base ()
    {
        Debug.Log("Create Shark");
        DiceNumber = 1;
    }

    // Generate the level of the Enemy
    protected override int generateLevel()
    {
        return NumbersUtils.RandomNumber(1, 10);
    }

    protected override double generateSpeed()
    {
        return this.level * 0.04;
    }
}

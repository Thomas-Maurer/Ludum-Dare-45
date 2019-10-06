using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat3 : Enemy
{
    public Boat3(): base ()
    {
        DiceNumber = 4;
    }

    // Generate the level of the Enemy
    protected override int generateLevel()
    {
        return NumbersUtils.RandomNumber(30, 40);
    }

    protected override double generateSpeed()
    {
        return this.level * 0.16;
    }
}

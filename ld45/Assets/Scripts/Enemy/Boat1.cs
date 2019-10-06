using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat1 : Enemy
{
    public Boat1(): base ()
    {
        DiceNumber = 2;
    }

    // Generate the level of the Enemy
    protected override int generateLevel()
    {
        return NumbersUtils.RandomNumber(10, 20);
    }

    protected override double generateSpeed()
    {
        return this.level * 0.2;
    }
}

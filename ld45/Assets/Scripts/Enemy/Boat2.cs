using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat2 : Enemy
{
    public Boat2(): base ()
    {
        DiceNumber = 3;
    }

    // Generate the level of the Enemy
    protected override int generateLevel()
    {
        return NumbersUtils.RandomNumber(20, 30);
    }

    protected override double generateSpeed()
    {
        return this.level * 1.2;
    }
}

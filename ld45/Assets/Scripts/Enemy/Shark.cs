﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : Enemy
{
    public Shark(): base ()
    {
        Debug.Log("Create Shark");
    }

    // Generate the level of the Enemy
    protected override int generateLevel()
    {
        return NumbersUtils.RandomNumber(5, 15);
    }

    protected override double generateSpeed()
    {
        return this.level * 0.04;
    }
}
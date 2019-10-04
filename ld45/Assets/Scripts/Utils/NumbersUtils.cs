using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class NumbersUtils : MonoBehaviour
{
    // Generate a random number between two numbers
public static int RandomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int level;
    // Start is called before the first frame update
    void Start()
    {
        this.level = this.generateLevel();
        Debug.Log("Hello: " + this.level);
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
}

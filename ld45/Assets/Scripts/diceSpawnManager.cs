using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceSpawnManager : MonoBehaviour
{

    public List<GameObject> PlayerSpawns = new List<GameObject>(7);
    public List<GameObject> EnemySpawns = new List<GameObject>(6);
    public List<GameObject> DicesJ = new List<GameObject>(6);
    public List<GameObject> DicesE = new List<GameObject>(6);
    public int diceResult;
    public int diceSpawn;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void diceRoller(string who,int diceResult , int diceSpawn)
    {
        Debug.Log("si j'apparait pas c'est la merde");
        if (who == "enemy")
        {
            Debug.Log("before instance");
            Instantiate(DicesE[diceResult],EnemySpawns[diceSpawn].transform);
            Debug.Log("after instance");
        }
        else if (who=="player")
        {
            Instantiate(DicesJ[diceResult], PlayerSpawns[diceSpawn].transform);
        }
    }
}

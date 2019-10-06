using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightingScript : MonoBehaviour
{
    public int dicesResult;
    public int finalResult;
    public int dices;
    public bool canThrow = true;
    public int enemyResult;
    public int i = 0;


    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.GetComponent<playerController>().health <= 0)
        {
            
        }

        
        if (gameObject.GetComponent<playerController>().opponent.GetComponent<Enemy>().Hp <= 0)
        {
            gameObject.GetComponent<playerController>().coins += gameObject.GetComponent<playerController>().opponent.GetComponent<Enemy>().CoinRewarded;
        }*/

        if (Input.GetKey(KeyCode.Space) && canThrow)
        {
            
            dices=GameObject.Find("player").GetComponent<playerController>().dicesAmount;
            

            finalResult = 0;
            for ( i = 0; i < dices; i++)
            {
                dicesResult = Random.Range(1, 6);
                Debug.Log(dicesResult);
                Debug.Log(i);
                GameObject.Find("SpawnManager").GetComponent<diceSpawnManager>().diceRoller("player", dicesResult, i);
                finalResult += dicesResult;
            }
            Debug.Log("playerResult :" + finalResult);



            finalResult = 0;
            for ( i = 0; i < dices; i++)
            {
                dicesResult = Random.Range(1, 6);
                GameObject.Find("SpawnManager").GetComponent<diceSpawnManager>().diceRoller("enemy", dicesResult, i);
                enemyResult += dicesResult;
            }
            Debug.Log("enemyResult :"+enemyResult);
            canThrow = false;

            if (finalResult>enemyResult)
            {
                GameObject.Find("player").GetComponent<playerController>().opponent.GetComponent<EnemyCtrl>().Enemy.Hp -= GameObject.Find("player").GetComponent<playerController>().damage;
            }
            else if (finalResult < enemyResult)
            {
                GameObject.Find("player").GetComponent<playerController>().health-= GameObject.Find("player").GetComponent<playerController>().opponent.GetComponent<EnemyCtrl>().Enemy.Damage;
            }
            else
            {
                GameObject.Find("player").GetComponent<playerController>().opponent.GetComponent<EnemyCtrl>().Enemy.Hp -= GameObject.Find("player").GetComponent<playerController>().damage;
                GameObject.Find("player").GetComponent<playerController>().health-=GameObject.Find("player").GetComponent<playerController>().opponent.GetComponent<EnemyCtrl>().Enemy.Damage;

            }

        }
    }
}

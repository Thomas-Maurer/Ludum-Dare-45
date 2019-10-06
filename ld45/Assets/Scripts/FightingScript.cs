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
    void Start ()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canThrow)
        {
            dices=GameObject.Find("player").GetComponent<playerController>().dicesAmount;
            

            finalResult = 0;
            for (int i = 0; i < dices; i++)
            {
                dicesResult = Random.Range(0, 6);
                finalResult += dicesResult;
            }
            Debug.Log("playerResult :" + finalResult);



            finalResult = 0;
            for (int i = 0; i < dices; i++)
            {
                dicesResult = Random.Range(0, 6);
                enemyResult += dicesResult;
            }
            Debug.Log("enemyResult :"+enemyResult);
            canThrow = false;

            if (finalResult>enemyResult)
            {
                //GameObject.FindWithTag("player").GetComponent<playerController>().opponent.GetComponent<ScriptVie>().health-=GameObject.FindWithTag("player").GetComponent<playerController>().damage;

            }
            else if (finalResult < enemyResult)
            {
                //GameObject.FindWithTag("player").GetComponent<playerController>().opponent.GetComponent<ScriptVie>().health-=GameObject.FindWithTag("player").GetComponent<playerController>().damage;

            }

        }
    }
}

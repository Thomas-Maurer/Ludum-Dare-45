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
    public GameObject spawnPointPlayer1;
    public GameObject spawnPointPlayer2;
    public GameObject spawnPointPlayer3;
    public GameObject spawnPointPlayer4;
    public GameObject spawnPointPlayer5;
    public GameObject spawnPointPlayer6;
    public GameObject spawnPointPlayer7;
    public GameObject spawnPointEnemy1;
    public GameObject spawnPointEnemy2;
    public GameObject spawnPointEnemy3;
    public GameObject spawnPointEnemy4;
    public GameObject spawnPointEnemy5;
    public GameObject spawnPointEnemy6;
    public List<GameObject> enemySpawnList =new List<GameObject>();

    private void Start()
    {
        //enemySpawnList= { spawnPointEnemy1,spawnPointEnemy2,spawnPointEnemy3};
    }




    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.GetComponent<playerController>().health <= 0)
        {

        }*/

        //vérifier que le script Enemy correspond et que la variable health aussi
        /*if (gameObject.GetComponent<playerController>().opponent.GetComponent<Enemy>.health <= 0)
        {

        }*/

        if (Input.GetKey(KeyCode.Space) && canThrow)
        {
            Debug.Log("dices");
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
                //GameObject.FindWithTag("player").GetComponent<playerController>().health-=GameObject.FindWithTag("player").GetComponent<playerController>().opponent.GetComponent<Enemy>().damage;

            }
            else
            {
                //GameObject.FindWithTag("player").GetComponent<playerController>().opponent.GetComponent<ScriptVie>().health-=GameObject.FindWithTag("player").GetComponent<playerController>().damage;
                //GameObject.FindWithTag("player").GetComponent<playerController>().health-=GameObject.FindWithTag("player").GetComponent<playerController>().opponent.GetComponent<Enemy>().damage;

            }

        }
    }
}

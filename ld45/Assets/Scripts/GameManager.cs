
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] EnemiesPrefab;
    [SerializeField]
    public GameObject[] RewardsPrefab;
    //List of all enemy in current game
    List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        GameObject SharkObject = EnemiesPrefab[0];
        GameObject rhum = RewardsPrefab[0];
        var SpawnSharkList = transform.Find("SpawnSharkList");
        var SpawnRewardsList = transform.Find("SpawnRewards");

        foreach (Transform child in SpawnSharkList)
        {
            GameObject enemyObject = Instantiate(SharkObject, new Vector2(child.position.x, child.position.y), Quaternion.identity);
            EnemyCtrl ctrl = enemyObject.GetComponent<EnemyCtrl>();
            Shark shark = new Shark();
            ctrl.init(shark);
        }

        foreach (Transform child in SpawnRewardsList)
        {
            GameObject enemyObject = Instantiate(rhum, new Vector2(child.position.x, child.position.y), Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createEnemy(EnumEnemyType enemyType)
    {
    }
}

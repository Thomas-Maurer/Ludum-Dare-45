
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
        GameObject Boat1Object = EnemiesPrefab[1];
        GameObject rhum = RewardsPrefab[0];
        var SpawnSharkList = transform.Find("SpawnSharkList");
        var SpawnBoat1List = transform.Find("SpawnBoat1List");
        var SpawnRewardsList = transform.Find("SpawnRewards");

        foreach (Transform child in SpawnSharkList)
        {
            GameObject enemyObject = Instantiate(SharkObject, new Vector2(child.position.x, child.position.y), Quaternion.identity);
            EnemyCtrl ctrl = enemyObject.GetComponent<EnemyCtrl>();
            Shark shark = new Shark();
            ctrl.init(shark);
        }

        foreach (Transform child in SpawnBoat1List)
        {
            GameObject enemyObject = Instantiate(Boat1Object, new Vector2(child.position.x, child.position.y), Quaternion.identity);
            EnemyCtrl ctrl = enemyObject.GetComponent<EnemyCtrl>();
            Boat1 boat1 = new Boat1();
            ctrl.init(boat1);
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

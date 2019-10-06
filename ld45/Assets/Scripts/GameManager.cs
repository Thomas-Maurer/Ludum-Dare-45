
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] EnemiesPrefab;
    //List of all enemy in current game
    List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        GameObject SharkObject = EnemiesPrefab[0];
        var test = transform.Find("SpawnSharkList");

        foreach (Transform child in test)
        {
            GameObject enemyObject = Instantiate(SharkObject, new Vector2(child.position.x, child.position.y), Quaternion.identity);
            EnemyCtrl ctrl = enemyObject.GetComponent<EnemyCtrl>();
            Shark shark = new Shark();
            ctrl.init(shark);
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


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

        foreach(GameObject go in EnemiesPrefab)
        {
            switch(go.name)
            {
                case "Shark":
                    GameObject enemyObject = Instantiate(go, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    EnemyCtrl ctrl = enemyObject.GetComponent<EnemyCtrl>();
                    Boat1 shark = new Boat1();
                    ctrl.init(shark);
                    break;
                default:
                    Debug.Log(go.name);
                    break;
            }
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

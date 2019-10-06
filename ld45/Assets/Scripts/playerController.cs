using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{

    public int moveSpeed = 10;
    public int health = 100;
    public int damage = 5;
    public int coins = 100;
    public int dicesAmount = 1;
    public bool isFighting = false;
    Rigidbody player;
    public bool hasEvolved = true;
    //public bool isHalfLvl = false;
    public GameObject opponent;

    public enum BoatLvl
    {
        noBoat,
        smallBoat,
        sailorShip,
        twoMats,
        manOWar,
    }
    public BoatLvl thisBoatLvl;


    void Start()
    {
        player = GetComponent<Rigidbody>();
        thisBoatLvl = BoatLvl.noBoat;
    }
    void FixedUpdate()
    {
        //movement
        if (Input.GetKey(KeyCode.Z))
        {
            player.velocity = Vector2.zero;
            transform.Translate(new Vector2(0, moveSpeed) * Time.deltaTime*2);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            player.velocity = Vector2.zero;
            transform.Translate(new Vector2(-moveSpeed, 0) * Time.deltaTime*2);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.velocity = Vector2.zero;
            transform.Translate(new Vector2(0, -moveSpeed) * Time.deltaTime*2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = Vector2.zero;
            transform.Translate(new Vector2(moveSpeed, 0) * Time.deltaTime*2);
        }

        //setActiveScene
        if (SceneManager.GetSceneByName("fighting").isLoaded && !isFighting)
        {

            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Fighting"));
            Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
            Time.timeScale = 0f;
            isFighting = true;
        }

        //BoatLvl
        if (!hasEvolved)
        {
            switch((int)thisBoatLvl)
            {
                case 1:
                    health = 10;
                    moveSpeed = 2;
                    dicesAmount = 2;
                    damage = 10;
                    gameObject.GetComponent<Renderer>().material.color = Color.black;
                    break;

                case 2:
                    health = 20;
                    moveSpeed = 4;
                    dicesAmount = 3;
                    damage = 15;
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    break;

                case 3:
                    health = 40;
                    moveSpeed = 6;
                    dicesAmount = 5;
                    damage = 20;
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    break;

                case 4:
                    health = 65;
                    moveSpeed = 8;
                    dicesAmount = 7;
                    damage = 25;
                    gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                    break;

            }
            hasEvolved = true;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            opponent = collision.gameObject;
            SceneManager.LoadScene("fighting", mode: LoadSceneMode.Additive);
            GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = false;
        }
        else if (collision.gameObject.tag == "island" && coins>=200)
        {
            coins -= 200;
            thisBoatLvl ++;
            hasEvolved = false;
        }
        else if (collision.gameObject.tag == "bonus")
        {

        }
    }

}

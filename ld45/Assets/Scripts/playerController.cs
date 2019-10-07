using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{

    public int moveSpeed = 1;
    public int health = 100;
    public int damage = 5;
    public int coins = 100;
    public int dicesAmount = 1;
    public bool isFighting = false;
    Rigidbody2D player;
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
    private Animator anim;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        thisBoatLvl = BoatLvl.noBoat;
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        Vector2 heading;
        //movement
        if (Input.GetKey(KeyCode.Z))
        {
            player.velocity = Vector2.zero;
            heading = new Vector2(0, moveSpeed) * Time.deltaTime * 2;
            transform.Translate(heading);
            anim.SetBool("isMoving", true);
            anim.SetFloat("xInput", heading.normalized.x);
            anim.SetFloat("yInput", heading.normalized.y);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            player.velocity = Vector2.zero;
            heading = new Vector2(-moveSpeed, 0) * Time.deltaTime * 2;
            transform.Translate(heading);
            anim.SetBool("isMoving", true);
            anim.SetFloat("xInput", heading.normalized.x);
            anim.SetFloat("yInput", heading.normalized.y);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            player.velocity = Vector2.zero;
            heading = new Vector2(0, -moveSpeed) * Time.deltaTime * 2;
            transform.Translate(heading);
            anim.SetBool("isMoving", true);
            anim.SetFloat("xInput", heading.normalized.x);
            anim.SetFloat("yInput", heading.normalized.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            player.velocity = Vector2.zero;
            heading = new Vector2(moveSpeed, 0) * Time.deltaTime * 2;
            transform.Translate(heading);
            anim.SetBool("isMoving", true);
            anim.SetFloat("xInput", heading.normalized.x);
            anim.SetFloat("yInput", heading.normalized.y);

        }else
        {
            anim.SetBool("isMoving", false);
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
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "enemy")
        {

            opponent = collider.gameObject;
            SceneManager.LoadScene("fighting", mode: LoadSceneMode.Additive);
            GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = false;
        }
        else if (collider.gameObject.tag == "island" && coins>=200)
        {
            coins -= 200;
            thisBoatLvl ++;
            hasEvolved = false;
            
        }
        else if (collider.gameObject.tag == "reward")
        {
            health += 5;
        }
        Debug.Log(collider.gameObject.tag);
    }

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraBehaviour : MonoBehaviour
{



    void Update()
    {
        transform.position = new Vector3(GameObject.Find("player").GetComponent<Transform>().position.x, GameObject.Find("player").GetComponent<Transform>().position.y, -10);

    }
}
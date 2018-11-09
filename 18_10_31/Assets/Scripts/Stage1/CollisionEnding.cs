﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnding : MonoBehaviour {

    public GameObject gameDirector;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //end object와 플레이어와 닿음
            gameDirector.GetComponent<GameDirector>().CollisionEndingObject();
            Debug.Log("CollisionEndingObject 호출");
        }
    }
}

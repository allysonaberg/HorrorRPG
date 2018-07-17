﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadNewArea : MonoBehaviour {

    public string levelToLoad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player") {
            
            //load into a new scene
            SceneManager.LoadScene(levelToLoad);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

    public string levelToLoad;
    public string exitPoint;
    private PlayerController thePlayer;
    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }
	// Update is called once per frame
	void Update () {
		
	}
//создание соответствующих точек входа и выхода из карты
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
            thePlayer.startPoint = exitPoint;
        }
                }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour {

    public float timeToDestroy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//удаление дупликатов игровых объектов при их появлении
        timeToDestroy -= Time.deltaTime;
        if(timeToDestroy<=0)
        { Destroy(gameObject); }
	}
}

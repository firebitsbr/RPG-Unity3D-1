﻿using UnityEngine;
using System.Collections;

public class EnemyBar : MonoBehaviour {

	public GameObject healt_bar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		healt_bar.transform.localScale = new Vector3((transform.GetComponent<Mob>().health/transform.GetComponent<Character>().max_healt),0.06f,0.06f);

	
	}
}

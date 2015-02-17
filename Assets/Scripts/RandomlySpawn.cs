﻿using UnityEngine;
using System.Collections;

public class RandomlySpawn : MonoBehaviour {

	public GameObject thing;

	public float minHorizPos = -10.0f;
	public float maxHorizPos = 10.0f;
	public float minVertiPos = -10.0f;
	public float maxVertiPos = 10.0f;

	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 1.0f;

	// Use this for initialization
	void Start () {
		Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
	}

	void SpawnNow() {
		GameObject newThing = Instantiate(thing,
		            transform.position + new Vector3(Random.Range(minHorizPos,maxHorizPos),
		                                 Random.Range(minVertiPos,maxVertiPos)),
		            Quaternion.identity) as GameObject;
		Debug.Log("The new thing is: " + newThing.ToString());
		newThing.transform.parent = gameObject.transform;
		Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

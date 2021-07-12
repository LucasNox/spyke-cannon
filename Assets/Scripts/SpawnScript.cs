using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SpawnScript : MonoBehaviour{
	public GameObject objects;
 	public float spawnTime = 6f;
	private Vector3 spawnPosition;
 	
	// Use this for initialization
	void Start () {
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
 
	void Spawn (){   
        spawnPosition.z = 0f; 
		if(Random.value > 0.5f){
            if(Random.value > 0.5f){
                spawnPosition.y = 2.5f;
                spawnPosition.x = Random.Range(-7f, 7f);
            }
            else{
                spawnPosition.y = -3.5f;
                spawnPosition.x = Random.Range(-7f, 7f);
            }
        }
        else{
           if(Random.value > 0.5f){
                spawnPosition.x = -7f;
                spawnPosition.y = Random.Range(-3.5f, 2.5f);
            }
            else{
                spawnPosition.x = 7f;
                spawnPosition.y = Random.Range(-3.5f, 2.5f);
            } 
        }
        Instantiate(objects, spawnPosition, Quaternion.identity);
	}
}
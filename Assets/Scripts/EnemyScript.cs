 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class EnemyScript : MonoBehaviour{

    private Rigidbody2D rb;
	public Transform target;

    float speed = 3f;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate(){
        Vector2 force = (target.position - transform.position);
        force.Normalize();
        rb.AddForce(force * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        //transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    }
 
}
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class EnemyScript : MonoBehaviour{

    private Rigidbody2D rb;
    [SerializeField]
	private Transform target;
    [SerializeField]
	private float speed;
    [SerializeField]
	private float topSpeed;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate(){
        rb.AddForce((target.position - transform.position) * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        if (rb.velocity.magnitude > topSpeed)
            rb.velocity = rb.velocity.normalized * topSpeed;
    }
 
}
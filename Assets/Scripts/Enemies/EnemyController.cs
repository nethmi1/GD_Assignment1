using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float speed;

	private Rigidbody2D myRigidBody;

	void Awake(){
		myRigidBody = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		EnemyMovement ();
	}

	void EnemyMovement(){
		myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, -speed);
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			collider.transform.GetComponent<PlayerController> ().PlayerDied ();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField ]private Vector2 jumpForceVector = new Vector2(0,100f);
	private Animator anim;
	private Rigidbody rigidBody;
	private bool jump = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();  //searchs the component in the object
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){ //left click
			anim.Play("Jump");
			rigidBody.useGravity = true;
			jump = true;

		}
	}

	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	void FixedUpdate(){
		if (jump == true){
			jump = false;
			rigidBody.velocity = new Vector2 (0,0);
			rigidBody.AddForce(jumpForceVector,ForceMode.Impulse);

		}

	}
}

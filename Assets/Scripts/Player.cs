using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour {

	[SerializeField] private Vector2 jumpForceVector = new Vector2(0,100f);
	[SerializeField] private AudioClip sfxJump;  // A sound clip to play in audio AudioSource
	[SerializeField] private AudioClip sfxDeath;
	private AudioSource audioSource; // The player -> we recive the  sound in a Listener in the camera
	private Animator anim;
	private Rigidbody rigidBody;
	private bool jump = false;
	private Vector2 nullVector = new Vector2 (0,0);
	private Vector2 explosionVector = new Vector2(100,-100);

	/// Awake is called when the script instance is being loaded.
	void Awake(){
		Assert.IsNotNull(sfxDeath);
		Assert.IsNotNull(sfxJump);
	}


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();  //searchs the component in the object
		rigidBody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){ //left click
			anim.Play("Jump");
			audioSource.PlayOneShot(sfxJump);
			rigidBody.useGravity = true;
			jump = true;

		}
	}

	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	void FixedUpdate(){
		if (jump == true){
			jump = false;
			rigidBody.velocity = nullVector;
			rigidBody.AddForce(jumpForceVector,ForceMode.Impulse);

		}

	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="collision">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "obstacle"){
			rigidBody.AddForce(explosionVector,ForceMode.Impulse);
			rigidBody.detectCollisions = false;
			audioSource.PlayOneShot(sfxDeath);
		}
	}
}

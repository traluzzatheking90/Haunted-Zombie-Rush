using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeObj : MonoBehaviour {

	[SerializeField] private float objectSpeed = 4;  // SerializeField allow us to modify a varible directly in the Inspector of the object
	private float resetPosition = 11.94f;
	private float restartPosition = -109.41f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));

		if(transform.localPosition.x >= resetPosition){
			Vector3 newPos = new Vector3(restartPosition, transform.position.y, transform.position.z);
			transform.position = newPos;

		}
	}
}

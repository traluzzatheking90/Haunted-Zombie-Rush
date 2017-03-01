using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeObj : MonoBehaviour {

	private const int deltaTimeMultiply = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * (deltaTimeMultiply * Time.deltaTime));
	}
}

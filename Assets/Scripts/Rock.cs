using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

	[SerializeField] Vector3 topPosition;
	[SerializeField] Vector3 bottomPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// View Coroutine : https://docs.unity3d.com/ScriptReference/Coroutine.html
	// View Start Coroutine : https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
	IEnumerator Move(Vector3 target){

		while(Mathf.Abs((target - transform.localPosition).y) > 0.20f){

			Vector3 direction = target.y == topPosition.y ? Vector3.up :Vector3.down;
			transform.localPosition += direction * Time.deltaTime;

			yield return null;

		}
	}
}

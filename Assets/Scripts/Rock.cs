using System.Collections;
using UnityEngine;

public class Rock : BridgeObj {

	[SerializeField] Vector3 topPosition;
	[SerializeField] Vector3 bottomPosition;
	[SerializeField] float speed;
	private float frameTime = 0.20f;

	// Use this for initialization
	void Start () {
		StartCoroutine (Move(bottomPosition));
	}

	/// Update is called every frame, if the MonoBehaviour is enabled.
	protected override void  Update(){
		base.Update();
	}
	
	// View Coroutine : https://docs.unity3d.com/ScriptReference/Coroutine.html
	// View Start Coroutine : https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
	IEnumerator Move(Vector3 target){

		while(Mathf.Abs((target - transform.localPosition).y) > 0.20f){

			Vector3 direction = target.y == topPosition.y ? Vector3.up :Vector3.down;
			transform.localPosition += direction * Time.deltaTime * speed;

			yield return null;
		}
		yield return new WaitForSeconds(0.3f);

		Vector3 newDirection = target.y == topPosition.y ? bottomPosition : topPosition;
		StartCoroutine (Move(newDirection));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
	public static GameManager instance = null;
	private bool playerActive = false;
	private bool gameOver = false;

	/// Awake is called when the script instance is being loaded.
	void Awake(){
		if (instance == null){
			instance = this;
		} else if (instance != this){
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// seters
	public void PlayerCollided(){
		gameOver = true;
	}

	public void PlayerStartedGame(){
		playerActive = true;
	}

	// Getters
	public bool PlayerActive{
		get { return playerActive;}
	}
	public bool GameOver{
		get { return gameOver;}
	}
}

using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour {
	public static GameManager instance = null;
	[SerializeField] private GameObject mainMenu;
	private bool playerActive = false;
	private bool gameOver = false;
	private bool gameStarted = false;

	/// Awake is called when the script instance is being loaded.
	void Awake(){
		if (instance == null){
			instance = this;
		} else if (instance != this){
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);

		Assert.IsNotNull(mainMenu);
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
	public void EnterGame(){
		mainMenu.SetActive (false);
		gameStarted = true;
	}
	// Getters
	public bool PlayerActive{
		get { return playerActive;}
	}
	public bool GameOver{
		get { return gameOver;}
	}
	public bool GameStarted{
		get { return gameStarted;}
	}
}

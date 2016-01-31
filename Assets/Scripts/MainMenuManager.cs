using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

	public string LevelSelectScene;


	public void StartGamePressed()
	{
		Application.LoadLevel(LevelSelectScene);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

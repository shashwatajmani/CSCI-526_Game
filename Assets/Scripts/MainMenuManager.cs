using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

	public string LevelSelectScene;


	public void StartGamePressed()
	{
		Application.LoadLevel(LevelSelectScene);

	}
	public void SettingsPressed()
	{
		Debug.Log("Settings Pressed");

		//Application.LoadLevel(LevelSelectScene);

	}
	public void AboutPressed()
	{
		Debug.Log("About Pressed");
		//Application.LoadLevel(LevelSelectScene);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

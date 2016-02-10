using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelUIManager : MonoBehaviour {

	public int FruitCollected;
	public Text fruitText;
	public string backBtnScene;

	// Use this for initialization
	void Start () {

		FruitCollected = 0;
	
	}

	public void BackPressed()
	{
		Application.LoadLevel(backBtnScene);

	}
		

	// Update is called once per frame
	void Update () {

	
	}
}

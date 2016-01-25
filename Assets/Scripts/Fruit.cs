using UnityEngine;
using System.Collections;

public class Fruit : MonoBehaviour {

	private GameObject gameManager;
	// Use this for initialization
	void Start () {

		gameManager = GameObject.Find("GameManager");
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter(Collision collision) 
	{		
		//Debug.Log(collision.gameObject.tag);
		if(collision.gameObject.tag == "Player")
		{
			gameManager.GetComponent<LevelUIManager>().FruitCollected++;
			gameManager.GetComponent<LevelUIManager>().fruitText.text = "Fruit: "+gameManager.GetComponent<LevelUIManager>().FruitCollected.ToString();

			Destroy(gameObject);
		}
	}
}

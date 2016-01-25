using UnityEngine;
using System.Collections;

public class SampleLevelSelectCollider : MonoBehaviour {

	public string nameOfLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnCollisionEnter(Collision collision) 
	{		
		//Debug.Log(collision.gameObject.tag);
		if(collision.gameObject.tag == "Player")
		{
			//gameManager.GetComponent<LevelUIManager>().FruitCollected++;
			//gameManager.GetComponent<LevelUIManager>().fruitText.text = "Fruit: "+gameManager.GetComponent<LevelUIManager>().FruitCollected.ToString();

			//Destroy(gameObject);

			Application.LoadLevel(nameOfLevel);

		}
	}
}

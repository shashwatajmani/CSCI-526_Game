using UnityEngine;
using System.Collections;

public class MovingObstacle : MonoBehaviour {

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
			Debug.Log("Collided with player!");
			collision.gameObject.transform.parent = gameObject.transform.parent;

		}
	}
	void OnCollisionExit(Collision collision) 
	{		

		//Debug.Log(collision.gameObject.tag);
		if(collision.gameObject.tag == "Player")
		{
			Debug.Log("Exit Collided with player!");
			collision.gameObject.transform.parent = null;
		}
	}
}

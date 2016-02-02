using UnityEngine;
using System.Collections;

public class MovingObstacle : MonoBehaviour {

	public GameObject m_mainParent;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{		

		//Debug.Log(collision.gameObject.tag);
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("Collided with player!");
			other.gameObject.transform.parent = m_mainParent.transform;

		}
	}
	void OnTriggerExit(Collider other) 
	{		

		//Debug.Log(collision.gameObject.tag);
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("Exit Collided with player!");
			other.gameObject.transform.parent = null;
		}
	}
}

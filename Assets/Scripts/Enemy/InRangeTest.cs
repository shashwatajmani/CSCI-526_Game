using UnityEngine;
using System.Collections;

public class InRangeTest : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider other)
	{
		if(other.tag == "Player")
		{
			Debug.Log("Player in Range");
			GetComponentInParent<FollowPlayerTest>().followObject = other.gameObject.transform;
		}
	}


}

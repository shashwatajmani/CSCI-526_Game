using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(player.transform.position);

		Vector3 Playertemp = player.transform.position;
		Vector3 camTemp = gameObject.transform.position;

		Playertemp.y = camTemp.y;

		float dist = Vector3.Distance(Playertemp,camTemp);
		//Debug.Log(dist);

	}
}

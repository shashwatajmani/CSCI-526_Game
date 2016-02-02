using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public VirtualJoyStick playerJoystick;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {

		//If there is movement
		if((playerJoystick.getVertical() != 0.0f)  ||
			playerJoystick.getHorizontal() != 0.0f)
		{
			
			
			transform.position = player.transform.position + offset;
		}
		else
		{
			offset = transform.position - player.transform.position;

		}
	}
}

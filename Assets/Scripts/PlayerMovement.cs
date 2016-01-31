using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public VirtualJoyStick movement_joystick;

	public Rigidbody m_rigidbody;
	private Vector3 moveVector;
	public Transform lookatPt;
	public Vector3 FowardMovementDirection;
	public GameObject cam;
	private Transform tempPlayer;


	// Use this for initialization
	void Start () {
		moveVector = new Vector3(0,0,0);
	
	}
	
	// Update is called once per frame
	void Update () {


		m_rigidbody.angularVelocity = Vector3.zero;
		moveVector.x = movement_joystick.getHorizontal();
		moveVector.z = movement_joystick.getVertical();


		if(moveVector != Vector3.zero)
		{
			Vector3 tempA = cam.GetComponent<roatateAround>().movementDirection * movement_joystick.getVertical();
			Vector3 tempRight = Vector3.Cross(Vector3.up,cam.GetComponent<roatateAround>().movementDirection);

			Vector3 tempB = tempRight * movement_joystick.getHorizontal();

			Vector3 newMoveVector = tempA + tempB;
			newMoveVector.Normalize();


			transform.forward = newMoveVector;

			m_rigidbody.velocity = newMoveVector*5;
		


		}


	}
}

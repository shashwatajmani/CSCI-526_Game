using UnityEngine;
using System.Collections;

public class roatateAround : MonoBehaviour {


	public GameObject target;
	public VirtualJoyStick joystick;

	private Vector3 localXAxis;
	private bool rotatingX;
	private bool rotatingY;

	public Vector3 movementDirection;


	void Start()
	{
		rotatingX = false;
		rotatingY = false;
		localXAxis = transform.right;

	}
	void Update() 
	{

		//Find the vector from the target of the camera to the camera positon(at same y as target )
		//Then normalize this vector.
		//This will give the direction that the player should go if I press forward

		movementDirection = new Vector3(transform.position.x, target.transform.position.y, transform.position.z );
		movementDirection = target.transform.position - movementDirection;
		movementDirection.Normalize();


		//Debug.Log( "Horz: "+joystick.getHorizontal() );
		//Debug.Log( "Vert: "+joystick.getVertical() );

		//Debug.Log(Vector3.Dot(Vector3.up,transform.forward));
		//Debug.Log(transform.forward);


		//Rotating around localXAxis

		if(  Mathf.Abs(joystick.getHorizontal()) <
			 Mathf.Abs(joystick.getVertical()) )
		{
			//Debug.Log("X");

			// If coming from rotatingY, set a new localXAxis before moving.
			if(rotatingY)
			{
				localXAxis = transform.right;	
			}



			transform.RotateAround(target.transform.position, localXAxis, joystick.getVertical() *50 * Time.deltaTime);



			rotatingX = true;
			rotatingY = false;

		}

		else
		{
			//Debug.Log("Y");



			transform.RotateAround(target.transform.position, Vector3.up, joystick.getHorizontal() *50* Time.deltaTime);

			rotatingX = false;
			rotatingY = true;

		}
	
	}








}



//How to limit the y-axis rotation:






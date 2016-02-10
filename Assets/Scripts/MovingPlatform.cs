using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;
	public Transform position2;
	public Vector3 newPosition;
	public string currentState;
	public float smooth;
	public float resetTime;


	void Start () {
		ChangeTarget ();
	}

	void FixedUpdate () {
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);
	}

	void ChangeTarget()
	{
		if (currentState == "Moving To Position 1") {
			currentState = "Moving To Position 2";
			newPosition = position2.position;
		}

		else if (currentState == "Moving To Position 2") {
			currentState = "Moving To Position 1";
			newPosition = position1.position;
		}

		else if (currentState == "") {
			currentState = "Moving To Position 2";
			newPosition = position2.position;
		}
		Invoke ("ChangeTarget", resetTime);

	}

}


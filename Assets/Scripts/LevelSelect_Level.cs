using UnityEngine;
using System.Collections;

public class LevelSelect_Level : MonoBehaviour {

	public string nameOfLevel;
	public float spinSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.up * Time.deltaTime * spinSpeed);	


	}
}

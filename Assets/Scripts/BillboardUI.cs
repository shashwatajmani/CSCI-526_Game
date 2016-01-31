using UnityEngine;
using System.Collections;

public class BillboardUI : MonoBehaviour {

	public GameObject m_camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(m_camera.transform);
		transform.forward = -transform.forward;
	
	}
}

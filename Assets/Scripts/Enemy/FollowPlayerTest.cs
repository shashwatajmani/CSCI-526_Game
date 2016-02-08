using UnityEngine;
using System.Collections;

public class FollowPlayerTest : MonoBehaviour {

	NavMeshAgent agent;
	public Transform followObject;

	// Use this for initialization
	void Start () {
	
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

		if(followObject)
		{
			agent.SetDestination(followObject.position);

		}
	
	}
}

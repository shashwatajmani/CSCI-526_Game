using UnityEngine;
using System.Collections;

public class LevelSelectTouchManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonUp(0) )
		{

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;

			if (Physics.Raycast(ray,out hit,50)/*Physics.Raycast (ray, hit)*/) 
			{
				//Debug.Log(" You just hit " + hit.collider.gameObject.name);
				if(  (hit.collider.tag == "Level_Select_Level"))
				{
				//	Debug.Log("You tapped a Level_Select_Level");

					Application.LoadLevel(hit.collider.gameObject.GetComponent<LevelSelect_Level>().nameOfLevel);
				}
			}

		}



		if(Input.touchCount > 0)
		{

			Touch myTouch = Input.GetTouch(0);
			Ray ray = Camera.main.ScreenPointToRay (myTouch.position);

			RaycastHit hit;

			if (Physics.Raycast(ray,out hit,50)/*Physics.Raycast (ray, hit)*/) 
			{
				//Debug.Log(" You just hit " + hit.collider.gameObject.name);
				if( (myTouch.phase == TouchPhase.Ended)&& (hit.collider.tag == "Level_Select_Level"))
				{
					//Debug.Log("You tapped a Level_Select_Level");

					Application.LoadLevel(hit.collider.gameObject.GetComponent<LevelSelect_Level>().nameOfLevel);
				}
			}
	
		}
	}
}

using UnityEngine;
using System.Collections;

public class DebugInfo : MonoBehaviour
{
	float deltaTime = 0.0f;
	public GameObject rotCube;
	bool isrotCube = false;

	void Update()
	{
		if(rotCube)
		{
			isrotCube = true;
		}
		else
		{
			isrotCube = false;

		}

		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
	}

	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(0, 0, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = h * 2 / 100;
		style.normal.textColor = new Color (0.0f, 0.0f, 0.5f, 1.0f);
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		if(rotCube)
		{
			text += " rotCube is there!";
			text += " " + rotCube.transform.rotation.y.ToString(); 
		}
		else
		{
			text += " rotCube is not there!";

		}
		GUI.Label(rect, text, style);
	}
}

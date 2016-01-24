using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class VirtualJoyStick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	public RectTransform pressArea;
	public Image bgImg;
	public Image knobImg;

	private Vector3 inputVector;

	private Vector3 orgPos;


	void Start()
	{
		orgPos = bgImg.rectTransform.anchoredPosition;	
	}

	IEnumerator retPosAfter (float secs)
	{
		yield return new WaitForSeconds(secs);
		bgImg.rectTransform.anchoredPosition =
			orgPos;
		knobImg.rectTransform.anchoredPosition =
			orgPos;
	}

	public virtual void OnDrag(PointerEventData ped)
	{
		
		Vector2 pos;
		RectTransformUtility.ScreenPointToLocalPointInRectangle( bgImg.rectTransform, ped.position, ped.pressEventCamera, out pos );


		pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
		pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

		inputVector = new Vector3(pos.x,0,pos.y);
		inputVector = (inputVector.magnitude > 1.0f)?inputVector.normalized:inputVector;

		//Debug.Log(inputVector);

		knobImg.rectTransform.anchoredPosition = new Vector3( bgImg.rectTransform.anchoredPosition.x + (inputVector.x * (bgImg.rectTransform.sizeDelta.x/2)),
			bgImg.rectTransform.anchoredPosition.y +(inputVector.z*(bgImg.rectTransform.sizeDelta.y/2)));

	}

	public virtual void OnPointerDown(PointerEventData ped)
	{

		// Position the JoyStick BG in the correct area!

		Vector2 pos;
		if( RectTransformUtility.ScreenPointToLocalPointInRectangle ( pressArea
			,ped.position
			,ped.pressEventCamera
			,out pos))
		{
			//Debug.Log("Press in Area!");

			StopCoroutine("retPosAfter");

			//Start animation of brigthening


			Vector2 bgPos = new Vector2(pos.x + pressArea.rect.width/2 , pos.y + pressArea.rect.height/2);

			//To keep inside the pressArea Assuming that the touch area pivot is in the center!
			if( (bgPos.x + bgImg.rectTransform.rect.width/2) > (pressArea.anchoredPosition.x + pressArea.rect.width/2))
			{
				//Debug.Log("Over the Right Side!");
				bgPos.x  = (pressArea.anchoredPosition.x + pressArea.rect.width/2) - bgImg.rectTransform.rect.width/2 ;

			}
			if( (bgPos.x - bgImg.rectTransform.rect.width/2) < (pressArea.anchoredPosition.x - pressArea.rect.width/2))
			{
				//Debug.Log("Over the Left Side!");
				bgPos.x  = (pressArea.anchoredPosition.x - pressArea.rect.width/2) + bgImg.rectTransform.rect.width/2 ;

			}

			if( (bgPos.y + bgImg.rectTransform.rect.height/2) > (pressArea.anchoredPosition.y + pressArea.rect.height/2))
			{
				//Debug.Log("Over the Top Side!");
				bgPos.y  = (pressArea.anchoredPosition.y + pressArea.rect.height/2) - bgImg.rectTransform.rect.height/2 ;

			}
			if( (bgPos.y - bgImg.rectTransform.rect.height/2) < (pressArea.anchoredPosition.y - pressArea.rect.height/2))
			{
				//Debug.Log("Over the Bottom Side!");
				bgPos.y  = (pressArea.anchoredPosition.y - pressArea.rect.height/2) + bgImg.rectTransform.rect.height/2 ;

			}

			bgImg.rectTransform.anchoredPosition =
				new Vector3(bgPos.x,bgPos.y);

			knobImg.rectTransform.anchoredPosition =
				bgImg.rectTransform.anchoredPosition;
		}


		OnDrag(ped);
	}
	public virtual void OnPointerUp(PointerEventData ped)
	{
		knobImg.rectTransform.anchoredPosition =
			bgImg.rectTransform.anchoredPosition;	

		inputVector.x = 0.0f;
		inputVector.z = 0.0f;


		StartCoroutine("retPosAfter",(3.0f));

		//Start Animation of diming.
	}

	public float getHorizontal()
	{
		return inputVector.x;
	}

	public float getVertical()
	{
		return inputVector.z;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHover : MonoBehaviour 
{
	public HiddenObject MyObject;
	public RectTransform Position;
	public Image Show;
	public bool Found = false;

	private HiddenController HC;


	public void StartText(HiddenController hc)
	{
		Position = gameObject.GetComponent<RectTransform> ();
		HC = hc;
	}
		
	public void ShowSilhouette()
	{
		if (Found == true)
			return;
		
		HC.SilhouetteIMG.sprite = MyObject.Myself.Silhouette;
		HC.TextIMG.gameObject.GetComponent<RectTransform> ().anchoredPosition = new Vector3 (Position.anchoredPosition.x,
																							 Position.anchoredPosition.y - 50 - (Position.sizeDelta.y / 2),
																							 0);
		HC.TextIMG.SetActive (true);
	}

	public void HideSilhouette()
	{
		HC.TextIMG.SetActive (false);
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortingItem : MonoBehaviour 
{
	public string Name;
	public string Description;
	public Sprite MyImage;
	public GameObject MyRange;
	[Space(10)]

	[Header("ENGINE")]
	public Item Myself;
	public Vector2 Scale;
	public RectTransform MyRangeRect;
	public bool InPosition = false;

	private Vector3 MPos;
	private RectTransform MyRect;
	private SortingController MySC;

	public void CreateItem(SortingController sc)
	{
		Myself = new Item (Name, Description, MyImage);		
		MyRect = GetComponent<RectTransform> ();
		MyRangeRect = MyRange.GetComponent<RectTransform> ();
		MySC = sc;
	}

	public void Click()
	{
		MPos = Input.mousePosition;
	}

	public void Drag()
	{ 
		if (InPosition)
			return;
		
		Vector3 dist = Input.mousePosition - MPos;
		MyRect.anchoredPosition = new Vector3 (MyRect.anchoredPosition.x + (dist.x * Scale.x), MyRect.anchoredPosition.y + (dist.y * Scale.y));
		MPos = Input.mousePosition;
	}

	public void Release()
	{
		if (InPosition)
			return;
		
		float distX = MyRect.anchoredPosition.x - MyRangeRect.anchoredPosition.x;
		float distY = MyRect.anchoredPosition.y - MyRangeRect.anchoredPosition.y;
		if (Mathf.Sqrt(distX*distX) + Mathf.Sqrt(distY*distY) < MyRangeRect.sizeDelta.x/2)
		{
			MyRect.anchoredPosition = MyRangeRect.anchoredPosition;
			InPosition = true;
			MySC.CheckFinish ();
		}
	}
}

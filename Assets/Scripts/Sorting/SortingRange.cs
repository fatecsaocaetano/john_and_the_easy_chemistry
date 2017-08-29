using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingRange : MonoBehaviour 
{
	public RectTransform Position;
	public RectTransform MyItem;

	public void CreateRanges()
	{
		Position = GetComponent<RectTransform> ();
	}
}

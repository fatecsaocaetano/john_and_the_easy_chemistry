using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingController : MonoBehaviour 
{
	public SortingItem[] ItemsInScene;
	public SortingRange[] RangeInScene;

	private Vector2 MyScreen;
	private Vector2 Scale;
	private Vector2 InverseScale;
	void Start()
	{
		MyScreen = new Vector2 (Screen.width, Screen.height);
		Scale = new Vector2 (MyScreen.x / 1280, MyScreen.y / 720);
		InverseScale = new Vector2 (1/Scale.x, 1/Scale.y);

		ItemsInScene = FindObjectsOfType<SortingItem> ();
		for (int i = 0; i < ItemsInScene.GetLength (0); i++) 
		{
			ItemsInScene [i].CreateItem (this);
			ItemsInScene [i].Scale = InverseScale;
		}
	}

	public void CheckFinish()
	{
		int count = 0;
		int total = ItemsInScene.GetLength (0);
		for (int i = 0; i < total; i++) 
		{
			if (ItemsInScene [i].InPosition)
				count++;
		}

		if (count == total)
			Debug.Log ("Finish");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject:MonoBehaviour
{
	[Header("INSERT OBJECT INFO")]
	public string Name;
	public string Description;
	public Sprite Silhouette;
	[Space(10)]
	public GameObject MyText;

	[Header("ENGINE, DON'T TOUCH THESE")]
	public HiddenController HC;
	public Item Myself;
	public bool Collected = false;

	public void CreateObject()
	{
		Myself = new Item (Name, Description, Silhouette);
	}

	public void Collect()
	{
		if (Collected)
			return;

		Collected = true;
		HC.ToInventory (this.gameObject, Myself, MyText);
		HC.CheckFinish ();
	}
}

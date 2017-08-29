using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item 
{
	public string Name;
	public string Description;
	public Sprite Silhouette;

	public Item(string n, string d, Sprite i)
	{
		Name = n;
		Description = d;
		Silhouette = i;
	} 
}

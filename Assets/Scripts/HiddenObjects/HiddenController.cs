using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenController : MonoBehaviour 
{
	public List<Item> MyObjects;
	public HiddenObject[] ObjectsInScene;
	public GameObject TextIMG;
	public Image SilhouetteIMG;

	[Header("Text")]
	public TextHover[] ObjectTexts;

	[Header("Inventory Settings")]
	public RectTransform IBackground;
	private float IOffset;


	void Start()
	{
		MyObjects = new List<Item> ();
		SilhouetteIMG = TextIMG.GetComponent<Image> ();

		//Setup objects
		ObjectsInScene = FindObjectsOfType<HiddenObject>();
		for (int i = 0; i < ObjectsInScene.GetLength(0); i++)
		{
			ObjectsInScene [i].HC = this;
			ObjectsInScene [i].CreateObject ();
		}
		IOffset = IBackground.sizeDelta.x / ObjectsInScene.GetLength (0)+1;

		//Setup Texts
		ObjectTexts = FindObjectsOfType<TextHover> ();
		for (int i = 0; i < ObjectTexts.GetLength (0); i++) 
		{
			ObjectTexts [i].StartText (this);
		}
	}

	public void ToInventory(GameObject obj, Item item, GameObject text)
	{
		MyObjects.Add (item);

		int count = MyObjects.Count;
		obj.transform.SetParent (IBackground.gameObject.transform);
		obj.GetComponent<RectTransform> ().anchoredPosition = new Vector2 ((-IBackground.sizeDelta.x / 2) + (IOffset * count) - (IOffset/2), 0);
		obj.GetComponent<Button> ().interactable = false;

		text.GetComponent<TextHover> ().Found = true;
		text.GetComponent<Text> ().color = Color.blue;
	}

	public void CheckFinish()
	{
		int count = 0;
		int total = ObjectsInScene.GetLength (0);
		for (int i = 0; i < total; i++) 
		{
			if (ObjectsInScene [i].Collected)
				count++;
		}

		if (count == total)
			Debug.Log ("Finish");
	}
}

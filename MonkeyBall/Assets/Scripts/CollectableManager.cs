using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class CollectableManager : MonoBehaviour 
{
	//public Text Collectables;

	private int nrOfTotalCollectables;
	private int nrOfCollectedItems;

	void Start()
	{
		GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
		nrOfTotalCollectables = collectables.Length;
		nrOfCollectedItems = 0;
		Debug.Log (nrOfTotalCollectables);
		//Update.UI();
	}
	public void Addcollectable()
	{
		nrOfCollectedItems++;
		Debug.Log("Je hebt " + nrOfCollectedItems + " van de" + nrOfTotalCollectables);
		if(nrOfCollectedItems == nrOfTotalCollectables)
		{
			Debug.Log("You Win!");
		}
		//void UpdateUI()
		//{
			//collectableText.text = "Collectables" + nrOfTotalCollectables + "of" + nrOfCollectedItems; 
		//}
	}
}
using UnityEngine;
using System.Collections;

public class SelectedItemBehaviour : MonoBehaviour {
	
	//Belom dipake masih coba2
	
	public Material OME_1;
	public Material OME_2;
	
	void OnMouseOver()
	{
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit()
	{
		if(gameObject.name.Equals("telor1"))
		{
			renderer.material = OME_1;
		}
		else
		{
			renderer.material.color = Color.blue;
		}
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

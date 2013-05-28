using UnityEngine;
using System.Collections;

public class L1_Gelas : MonoBehaviour {
	
	bool isClicked = false;
	
	void OnMouseEnter()
	{
		if(isClicked == true)
		{
			renderer.material.color = Color.green;
		}
		else
		{
			renderer.material.color = Color.yellow;
		}
	}
	
	void OnMouseExit()
	{
		
		if(isClicked == true)
		{
			renderer.material.color = Color.green;
		}
		else
		{
			renderer.material.color = Color.white;
		}
	}
	
	void OnMouseUpAsButton()
	{
		renderer.material.color = Color.green;
		isClicked = true;
		GameObject.Find("check_gelas").renderer.enabled = true;
		audio.Play();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

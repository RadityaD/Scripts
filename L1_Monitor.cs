using UnityEngine;
using System.Collections;

public class L1_Monitor : MonoBehaviour {
	
	bool isClicked = false;
	
	void OnMouseEnter()
	{
		if(isClicked == true)
		{
			renderer.material.color = Color.red;
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
			renderer.material.color = Color.red;
		}
		else
		{
			renderer.material.color = Color.black;
		}
	}
	
	void OnMouseUpAsButton()
	{
		renderer.material.color = Color.red;
		isClicked = true;
		GameObject.Find("cross_monitor").renderer.enabled = true;
		audio.Play();
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

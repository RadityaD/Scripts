using UnityEngine;
using System.Collections;

public class StartButtonBehaviour : MonoBehaviour {
	
	
	// Tombol start awal

	public string namaguitexture;
	public GameObject target1;
	public GameObject target2;
	
	
	
	void OnMouseOver()
	{
		// Waktu dihover ganti warna / tint
		if(gameObject.name.Equals(namaguitexture))
		{
			guiTexture.color = Color.red;
		}
	}
	
	void OnMouseExit()
	{
		// Ngebalikin warna pas ga kena mouse
		if(gameObject.name.Equals(namaguitexture))
		{
			guiTexture.color = Color.grey;
		}
		
	}
	
	void OnMouseUpAsButton()
	{
		// Ngilangin menu-nya pas pencet Start
		if(gameObject.name.Equals(namaguitexture))
		{
			
			Destroy(gameObject);
			target2 = GameObject.Find("LogoPama");
			Destroy(target2);
			target1 = GameObject.Find("CameraControl");
			target1.animation.Play("overview");
		}
	}
	
	
	// Use this for initialization
	void Start () {
		OnMouseOver();
		OnMouseExit();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

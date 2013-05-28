using UnityEngine;
using System.Collections;

public class LevelButtonBehaviour : MonoBehaviour {
	
	/*bikin public variable klo mau bikin modul
	*public int contoh;
	*nanti bisa diganti via unity-nya
	*/
	
	public string object1, light1, light2, anim1, anim2, animlvl, reactive2d, exitbtn;
	public static bool showGUI = false;
	public GameObject timer;
	
	//public static bool reenableGUI;
	//public ExitButtonBehaviour exitscript;
	
	IEnumerator waitTimer()
    {
        yield return new WaitForSeconds (1.5f);
        timer.SetActive(true);          
    }
	
	void OnMouseEnter()
	{		
		// Warna Tulisan Level 1 Keliatan
		Color color = renderer.material.color;
		color.a = 1f;
		GameObject.Find(object1).renderer.material.color = color;
		
		//Lighting
		GameObject.Find(light1).light.intensity = 2;
		GameObject.Find(light2).light.intensity = 0;
		
		// Jalanin Animasi Gede Kecilin lvlbtn
		if(!animation.isPlaying)
		{
			animation.Play(anim1);
		}
		
	}
	
	void OnMouseExit()
	{
		// Warna Tulisan Level 1 Biar Ga Keliatan / Transparan
		Color color = renderer.material.color;
		color.a = 0f;
		GameObject.Find(object1).renderer.material.color = color;
		
		//Lighting
		GameObject.Find(light1).light.intensity = 1;
		GameObject.Find(light2).light.intensity = 2;
		
		// Animasi Keluar lvlbtn
		//animation.Play(anim2);
		animation.Stop(anim1);
		
	}
	
	void OnMouseUpAsButton()
	{
		GameObject.Find(animlvl).animation.Play("cam_level1_zoomin", PlayMode.StopAll);	
		
		
		//FLAG buat show gui
		showGUI = true;
		StartCoroutine(waitTimer());
	
		//Aktifin Lagi GUI yang di-disable
		GameObject.Find("exitbtn").GetComponent<ExitButtonBehaviour>().enabled = true;
		
		//reenableGUI = true;
		//exitscript.OnGUI();
	}
	
	// Use this for initialization
	void Start () {
		
		// Warna Tulisan Level 1 Biar Ga Keliatan / Transparan
		Color color = renderer.material.color;
		color.a = 0f;
		GameObject.Find(object1).renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

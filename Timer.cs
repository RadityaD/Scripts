using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	
	string taimer;
	float startTime;
	
	void OnGUI()
	{
			
		float waktu = Time.time - startTime;
		
		float menit = waktu /60;
		float detik = waktu % 60;
		float fraction = (waktu * 100) %100;
		
		taimer = string.Format("{0:00}:{1:00}:{2:000}", menit, detik, fraction);
		GUI.Label (new Rect (10, Screen.height -30, 100, 30), taimer);
		
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

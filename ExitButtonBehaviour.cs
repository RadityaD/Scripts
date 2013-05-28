using UnityEngine;
using System.Collections;

public class ExitButtonBehaviour : MonoBehaviour {
	
	public GameObject timer;
	void OnMouseUpAsButton()
	{
		
		//GameObject.Find("CameraControl").transform.position = new Vector3(5.211234f, 8.375241f, -12.55853f);
		//GameObject.Find("CameraControl").transform.localEulerAngles = new Vector3(0f, 0f, 0f);  // LOCAL EULER ANGLES Buat ngeSET Rotasi dlm transform
	}
	
	
	public void OnGUI()
	{	
		if(LevelButtonBehaviour.showGUI == true)
		{
			//if(GameObject.Find("CameraControl").animation.isPlaying)
			if(GUI.Button(new Rect(Screen.width - 60,Screen.height - 30,50,25), "EXIT"))
			{
					// Exit button, balikin kamera ke level view
					GameObject.Find("CameraControl").animation.Stop();
					GameObject.Find("CameraControl").transform.position = new Vector3(5.211234f, 8.375241f, -12.55853f);
					GameObject.Find("CameraControl").transform.localEulerAngles = new Vector3(0f, 0f, 0f);  // LOCAL EULER ANGLES Buat ngeSET Rotasi dlm transform
				
					timer.SetActive(false);
					LevelButtonBehaviour.showGUI = false;
			}
		}
		else
		{
			
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//print(GameObject.Find("CameraControl").transform.position.x);
		//print(GameObject.Find("CameraControl").transform.position.y);
		//print(GameObject.Find("CameraControl").transform.position.z);
		//print(GameObject.Find("CameraControl").transform.rotation.x);
		//print(GameObject.Find("CameraControl").transform.rotation.y);
		//print(GameObject.Find("CameraControl").transform.rotation.z);
	
	}
}

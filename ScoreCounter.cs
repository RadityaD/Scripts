using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {
	
	
	private int counter;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = ""+counter;
	}
}

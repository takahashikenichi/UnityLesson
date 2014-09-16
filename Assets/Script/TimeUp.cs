using UnityEngine;
using System.Collections;

public class TimeUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "TimeUp!\nScore:" + Score.score;	
	}
}

﻿using UnityEngine;
using System.Collections;

public class TouchRotation : MonoBehaviour
{
	public Vector3 angle;
	public float stopAngleY = 90;

	bool mouseDown = false;
	TextMesh numberGUIText;
	string number = "1";

	public void SetNumber(string numberString) {
		number = numberString;
	}

	void Awake(){
		foreach(Transform child in transform) {
			if(child.name == "Number") {
				numberGUIText = (TextMesh)child.GetComponent(typeof(TextMesh));
			}
		}
	}

	// Use this for initialization
	void Start ()
	{
		mouseDown = false;
	}
	// Update is called once per frame
	void Update ()
	{
		if(numberGUIText != null) {
			numberGUIText.text = number;
		}

		if(mouseDown) {
			if(numberGUIText != null) {
				numberGUIText.text = number;
				numberGUIText.color = Color.yellow;
			}

			if( stopAngleY < 0) {
				if(transform.rotation.eulerAngles.y > 360 + stopAngleY || transform.rotation.eulerAngles.y == 0) {
					transform.Rotate (angle * Time.deltaTime);
				} else {
					// 指定した値でぴったり止める
					transform.eulerAngles = new Vector3(0, 360 + stopAngleY, 0);
					mouseDown = false;
				}
			} else {
				if(transform.rotation.eulerAngles.y < stopAngleY) {
					transform.Rotate (angle * Time.deltaTime);	
				} else {
					// 指定した値でぴったり止める
					transform.eulerAngles = new Vector3(0, stopAngleY, 0);
					mouseDown = false;
				}
			}
		}
	}

	void OnMouseDown ()
	{
		mouseDown = true;
	}
}

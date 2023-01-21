using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibeFadeOut : MonoBehaviour
{
    private float nextTime;
	public float interval = 1.0f;	// 点滅周期

	// Use this for initialization
	void Start() {
		nextTime = Time.time;
	}

	// Update is called once per frame
	void Update() {
		if ( Time.time > nextTime ) {
			GetComponent<SkinnedMeshRenderer>().enabled = !GetComponent<SkinnedMeshRenderer>().enabled;

			nextTime += interval;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//#if UNITY_EDITOR_OSX
//// no VR
//#define NO_VR
//#endif

public class VRDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		try {
			Valve.VR.OpenVR.GetInitToken();
			DisableNonVR();
		} catch (DllNotFoundException e) {
			DisableVR();
		}
	}

	void DisableVR() {
		print("Disabling VR");
		var vrCam = GameObject.Find("Camera (head)");
		vrCam.SetActive(false);
	}

	void DisableNonVR() {
		print("Disabling Non-VR camera etc.");
//		this.gameObject.SetActive(false);
		GetComponent<AudioListener>().enabled = false;
	}
}

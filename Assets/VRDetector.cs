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
		} catch (DllNotFoundException e) {
			print("Disabling VR");
			DisableVR();
		}
	}

	void DisableVR() {
		var vrCam = GameObject.Find("Camera (head)");
		vrCam.SetActive(false);

	}
}

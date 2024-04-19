﻿using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at

	// Called when MouseDown on this gameObject
	public void OnClick () {
		// change the target of the LookAtTarget script to be this gameobject.
		//Camera.main.GetComponent<LookAtTarget>().target = target;
		// change the field of view on the perspective camera based on the distance from center of world, clamp it to a reasonable field of view
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
	}
}

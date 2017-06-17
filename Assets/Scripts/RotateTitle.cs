using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0.03f, 0, Space.World);
	}
}

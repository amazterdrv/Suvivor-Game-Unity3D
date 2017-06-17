using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
      File.CreateText("savegame.data").WriteLine("Hello");
    }
}

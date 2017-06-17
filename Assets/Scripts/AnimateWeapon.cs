using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWeapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Animation>().Play("Weaponanimate");
        }
	}
}

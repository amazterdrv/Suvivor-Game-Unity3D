using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        this.transform.position = target.position;
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = null;
    }
}

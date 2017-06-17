using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour {
    public static int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    void OnGUI()
    {
        Rect rect = new Rect(10, 10, 90, 40);
        GUI.Label (rect, ("Coins: " + count));
        //Rect rect = new Rect(10, 10, 90, 40);
    }
}

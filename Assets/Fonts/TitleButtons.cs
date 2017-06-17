using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        Rect position1 = new Rect(Screen.width / 2 - 50, Screen.height / 2,100, 30);
        if (GUI.Button(position1, "Play Game"))
        {
            SceneManager.LoadScene(1);
        }

        Rect position2 = new Rect(Screen.width / 2 - 50, Screen.height / 2 + 40, 100, 30);
        if (GUI.Button(position2, "Quit"))
        {
            Application.Quit();
        }

    }
}

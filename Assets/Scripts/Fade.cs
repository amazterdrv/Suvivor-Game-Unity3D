using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {
    public GameObject Black;
    public GameObject FadeScreen;

	// Use this for initialization
	void Start () {
        StartCoroutine(Example());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.99f);
        FadeScreen.GetComponent<Animator>().enabled = true;
        Black.SetActive(false);
       // yield return new WaitForSeconds(0.99f);
        FadeScreen.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(false);
    }
}

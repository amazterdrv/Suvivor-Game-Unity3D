using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartQuest : MonoBehaviour {
    public GameObject panel1;
    public GameObject panel2;
    public GameObject text1;
    public GameObject text2;

	// Use this for initialization
	void Start () {
        panel1.SetActive(true);
       
        StartCoroutine(example());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator example()
    {
        yield return new WaitForSeconds(3);
        text1.GetComponent<Text>().text = "Where the fuck am I????";
        yield return new WaitForSeconds(1);
        text1.GetComponent<Text>().text = "I need to exit the woods";
        yield return new WaitForSeconds(1);
        panel1.SetActive(false);
        text2.GetComponent<Text>().text = "Quest:Exit the woods";
    }
}

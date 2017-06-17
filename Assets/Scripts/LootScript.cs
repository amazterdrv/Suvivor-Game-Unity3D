using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootScript : MonoBehaviour {
    public GameObject ObjectToHide;
    public GameObject ObjectToShow;
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;
    public GameObject QuestBox;
    public GameObject QuestText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if(TextBoxOnCheck==0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "Yup! You found the loot ";
            ObjectToShow.SetActive(true);
            ObjectToHide.SetActive(false);
            
        }
        else
        {
            MessageBox.SetActive(false);
            gameObject.SetActive(false);
        }
        
    }
    IEnumerator Example()
    {
       // print(Time.time);
        yield return new WaitForSeconds(10);
        //print(Time.time);
    }
}

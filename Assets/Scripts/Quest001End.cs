using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001End : MonoBehaviour {

    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;
    public GameObject QuestBox;
    public GameObject QuestText;
    string QuestName;
    public string TextMessage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            // TextMessage = "Obtain the finest piece of sexual choc from the other side of river";
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "Thank you very much for your precious time you lazy fuck";
            QuestName = "Active Quest: None";
            QuestText.GetComponent<Text>().text = QuestName;
        }
        else
        {
            TextBoxOnCheck = 0;
            TextMessage = "Fuck off then";
            MessageBox.SetActive(false);
        }
    }

}

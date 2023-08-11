using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Menu : MonoBehaviour {

    public GameObject canvas;

    public GameObject helloMessage;
    public GameObject copyrightMessage;

    public void Start(){

        print($"Width: {Screen.width}\nHeigth: {Screen.height}");

        canvas = new GameObject("Canvas", typeof(Canvas));

        string msg = $"Welcome To SuperPong++";
        helloMessage = new GameObject(msg, typeof(TextMeshProUGUI));
        helloMessage.transform.SetParent(canvas.transform);
        helloMessage.transform.position = new Vector3(0,0,5);
        helloMessage.GetComponent<TextMeshProUGUI>().fontSize = 1;
        helloMessage.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
        helloMessage.GetComponent<TextMeshProUGUI>().text = msg;

        //Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2 , Screen.height - (1 + 10) ,5));

        string msg = $"Welcome To SuperPong++";
        copyrightMessage = new GameObject(msg, typeof(TextMeshProUGUI));
        copyrightMessage.transform.SetParent(canvas.transform);
        copyrightMessage.transform.position = new Vector3(0,0,5);
        copyrightMessage.GetComponent<TextMeshProUGUI>().fontSize = 1;
        copyrightMessage.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
        copyrightMessage.GetComponent<TextMeshProUGUI>().text = msg;
    }

    public void Update(){

    }
}
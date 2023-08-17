using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Menu : MonoBehaviour {

    public AssetBundle assets;

    public GameObject camera;
    public GameObject canvas;

    public GameObject helloMessageObj;
    public GameObject copyrightMessageObj;
    public GameObject buttonStartObj;

    public int teste = 0;

    public void Start(){
        //assets = AssetBundle.LoadFromFile("/Assets/Scenes/Game.unity");
        //assets.GetAllScenePaths();
       //Path.Combine(Directory.GetCurrentDirectory(), "Assets", "Scenes")
       var hello = Resources.Load($"{Path.Combine(Directory.GetCurrentDirectory(), "Assets", "Scenes")}");

        print(hello);


        camera = new GameObject("Camera", typeof(Camera)/*,typeof(AudioListener)*/);
        camera.transform.position = new Vector3(0,0,-10);
        camera.GetComponent<Camera>().orthographic = true;

        canvas = new GameObject("Canvas", typeof(Canvas));
        //canvas.GetComponent<Canvas>().renderMode.eventCamera = camera.GetComponent<Camera>();
        //canvas.GetComponent<Canvas>().vertexColorAlwaysGammaSpace = true;
        canvas.GetComponent<Canvas>().worldCamera = camera.GetComponent<Camera>();

        string msg = $"Welcome To SuperPong++";
        helloMessageObj = new GameObject($"Text - {msg}", typeof(TextMeshProUGUI));

        var helloMessage = helloMessageObj.GetComponent<TextMeshProUGUI>();
        helloMessage.transform.SetParent(canvas.transform);
        helloMessage.transform.position = new Vector3(0,0,5);
        helloMessage.fontSize = 1;
        helloMessage.alignment = TextAlignmentOptions.Center;
        helloMessage.GetComponent<TextMeshProUGUI>().text = msg;

        msg = $"Copyright © 2023 Heloísa Real, Mateus Felipe da Silveira Vieira, Thiago Babtista da Silva Soares";
        copyrightMessageObj = new GameObject($"Text - {msg}", typeof(TextMeshProUGUI));
        var copyrightMessage = copyrightMessageObj.GetComponent<TextMeshProUGUI>();
        copyrightMessage.transform.SetParent(canvas.transform);
        copyrightMessage.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2 , Screen.height / 12 ,5));
        copyrightMessage.fontSize = 0.35F;
        copyrightMessage.alignment = TextAlignmentOptions.Center;
        copyrightMessage.text = msg;

/*
        var buttonCameraPlace = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2 , Screen.height / 4 ,5));
        msg = $"Start";
        buttonStartObj = new GameObject($"Button - {msg}", typeof(Button), typeof(Image));
        buttonStartObj.transform.SetParent(canvas.transform);
        buttonStartObj.transform.position = buttonCameraPlace;
        buttonStartObj.GetComponent<RectTransform>().sizeDelta = new Vector2(5,1);

        GameObject subtextObj = new GameObject($"SubText - {msg}", typeof(TextMeshProUGUI));
        subtextObj.transform.SetParent(buttonStartObj.transform);
        subtextObj.transform.position = buttonCameraPlace;
        var subtext = subtextObj.GetComponent<TextMeshProUGUI>();
        subtext.color = new Color(0,0,0, 1);
        subtext.fontSize = 1;
        subtext.alignment = TextAlignmentOptions.Center;
        subtext.text = msg;

        var buttonStart = buttonStartObj.GetComponent<Button>();*/

        //print(buttonStart.GetMethods());

        //buttonStart.height = 1;

        //buttonStartObj.GetComponent<Button>().onClick.AddListener(() => print("you clicked"));
    }

    public void Update(){



        //print($"Thread Awake");
        //SceneManager.LoadScene("Game");
    }

    public void OnGUI(){
        if (GUI.Button(new Rect(Screen.width / 2.28F, Screen.height / 1.35F, 100, 30), "Start Game"))
        {
            Debug.Log("Scene2 loading: ");
            print("fghfhgy");
            SceneManager.LoadScene("TesteScene.unity");
        }
    }
}


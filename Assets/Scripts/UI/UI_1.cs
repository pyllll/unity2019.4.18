using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_1 : MonoBehaviour
{

    //private Button BtnExit;
    //private Button Btn2;
    private GameObject ExitWindow;
    // Start is called before the first frame update
    void Start()
    {
        //BtnExit = this.GetComponent<Button>();
        //BtnExit.onClick.AddListener(ExitWindows);

        //Btn2 = this.GetComponent<Button>();
        //Btn2.onClick.AddListener(Test2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Test2()
    { 
        Debug.Log("create a card");
    }

    public void ExitWindows()
    {
        //ControlMessageBox.Instance.SetMessage("游戏退出");
        Debug.Log("this is a test1");
        #if UNITY_EDITOR

            UnityEditor.EditorApplication.isPlaying = false;

            Debug.Log ("编辑状态游戏退出");

        #else
        //Debug.Log("游戏退出"):
        Application.Quit();

        

        #endif
        //Application.Quit();
        //ExitWindow.SetActive(true);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine.UIElements;

public class UIHandlerScene01 : MonoBehaviour
{
    public InputField playerInput1;
    private string playerStr1;
    public Button exitBtn;
    public Button toScene2;


    // Start is called before the first frame update
    void Start()
    {
        playerInput1 = InputField.FindObjectOfType<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerText1 ; // duda, no se como asignar texto del inputfield
    }

    public void ReadInput(string s)
    {
        playerStr1 = s;
        Debug.Log("playerText1 = " + playerInput1.text);

        DataManager.Manager.player = playerStr1;
        Debug.Log("Leyendo entrada (playerStr1): " + playerStr1);
    }

    public void ToScene2()
    {
        //SceneManager.LoadScene();
        //SceneManager.SetActiveScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}

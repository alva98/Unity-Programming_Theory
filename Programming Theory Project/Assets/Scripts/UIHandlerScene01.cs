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
    public InputField playerText1;
    public string playerStr1;

    // Start is called before the first frame update
    void Start()
    {
        playerText1 = InputField.FindObjectOfType<InputField>();
        Debug.Log("playerText1 = " + playerText1);
    }

    // Update is called once per frame
    void Update()
    {
        //playerText1 ; // duda, no se como asignar texto del inputfield
    }

    public void ReadInput(string s)
    {
        playerStr1 = s;
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

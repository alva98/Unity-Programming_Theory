using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class UIHandlerScene01 : MonoBehaviour
{
    public InputField playerInput1;
    public InputField figureGeo;
    private int figureInt1;
    public Button toScene2;
    public Button exitBtn;

    // Start is called before the first frame update
    void Start()
    {
        playerInput1 = InputField.FindObjectOfType<InputField>();
        exitBtn = Button.FindObjectOfType<Button>();
        toScene2 = Button.FindObjectOfType<Button>();

        if (PlayerPrefs.HasKey("Ultima Figura"))
        {
            figureInt1 = PlayerPrefs.GetInt("Ultima Figura");   // ensayando código desconocido
            figureGeo.text = figureInt1.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Read player's name
    public void ReadPlayerInput(string s)
    {
        GameManager.Manager.Player = playerInput1.text;
        Debug.Log("GameManager.Manager.Player: " + GameManager.Manager.Player);
    }

    // Read figure geometric number
    public void ReadFigureGeoInput(int s)
    {
        GameManager.Manager.FigureNum = Convert.ToByte(figureGeo.text);
        Debug.Log("GameManager.Manager.FigureNum: " + GameManager.Manager.FigureNum);
    }

    // Verify completed textbox and loading scene 02
    public void ToScene2()
    {
        if (playerInput1.text == null || playerInput1.text == "")
        {
            Debug.Log("No se coloco el nombre del jugador.");
            SceneManager.LoadScene(0);
        }
        else if(figureGeo.text == null || Convert.ToByte(figureGeo.text) < 1 || Convert.ToByte(figureGeo.text) > 3)
        {
            Debug.Log("No se coloco el número de la figura.");
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    // Exit of the app
    public void Exit()
    {
        Debug.Log("Terminado --- Usuario: " + GameManager.Manager.Player);  // Finish with player's name in console
        // Save name of player on exit
        GameManager.Manager.SavePlayer();

        // Compiler pre-directive to quit Unity player
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}

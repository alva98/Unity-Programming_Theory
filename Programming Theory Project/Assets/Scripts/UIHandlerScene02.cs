using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandlerScene02 : MonoBehaviour
{
    public Text playerText2;
    public Text figureText2;
    public Button backToScene01;

    // Start is called before the first frame update
    void Start()
    {
        ShowPlayer();
        ShowShape();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPlayer()
    {
        playerText2.text = "Jugador: " + GameManager.Manager.Player;
    }

    public void ShowShape()
    {
        int i = GameManager.Manager.FigureNum;
        if (i == 1)
        {
            SquareShape sqShape = new SquareShape();
            figureText2.text = sqShape.Shape(i);
        }
        else if (i == 2)
        {
            RectShape reShape = new RectShape();
            figureText2.text = reShape.Shape(i);
        }
        else
        {
            TriShape trShape = new TriShape();
            figureText2.text = trShape.Shape(i);
        }
    }

    public void BackToScene1()
    {
        SceneManager.LoadScene(0);
        //SceneManager.SetActiveScene(0);
    }
}

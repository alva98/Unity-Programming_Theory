using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandlerScene02 : MonoBehaviour
{
    public Text playerText2;

    // Start is called before the first frame update
    void Start()
    {
        playerText2.text = "Player: " + GameManager.Manager.Player;
        Debug.Log("(UIHndlerScne02) - playerText2 - " + playerText2.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class FigureBase
    {
        public virtual void FigureGeo()
        {
            Debug.Log("Clase padre - Figura base");
        }
    }

    public class FigureSquare : FigureBase
    {
        public override void FigureGeo()
        {
            float width = 3.0f;
            Debug.Log("Figura cuadrado: lado = " + width + " - Area = " + width*width);
        }
    }

    public void BackToScene1()
    {
        SceneManager.LoadScene(0);
        //SceneManager.SetActiveScene(0);
    }
}

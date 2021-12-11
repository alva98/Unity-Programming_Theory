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
        playerText2.text = GameManager.Manager.Player;
        Debug.Log("playerText2 = " + playerText2.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToScene1()
    {
        SceneManager.LoadScene(0);
        //SceneManager.SetActiveScene(0);
    }
}

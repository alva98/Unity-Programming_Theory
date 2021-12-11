using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SaveData
{
    private string _playerData;
    public string PlayerData
    {
        get { return _playerData; }
        set { _playerData = value; }
    }

    private int _figureNumData;
    public int FigureNumData
    {
        get { return _figureNumData; }
        set { _figureNumData = value; }
    }
}

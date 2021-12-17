using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // private static GameManager _manager;
    public static GameManager Manager { get; private set; }     // forma abreviada

    private string _player;             // variable, nombre del jugador
    public string Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private int _figureNum;             // variable, numero de opción de figura
    public int FigureNum
    {
        get { return _figureNum; }
        set { _figureNum = value; }
    }

    private void Awake()
    {
        if(Manager != null)
        {
            Destroy(gameObject);        // destruye instancias anteriores
            return;
        }
        Manager = this;                // crea la instancia
        DontDestroyOnLoad(gameObject);  // no destruye el objeto
        LoadPlayer();                   // carga nombre del jugador al principio
    }

    public void SavePlayer()
    {
        SaveData data = new SaveData();
        data.PlayerData = _player;                                          // asigna valor de _player (clase GameManager) a _playerData (clase SaveData)
        data.FigureNumData = _figureNum;                                    // asigna valor de _figureNum (clase GameManager) a _figureNumData (clase SaveData)

        string path = Application.persistentDataPath + "/GameData.json";    // ruta y nombre de archivo guardado para persistencia de datos
        string jsonFile = JsonUtility.ToJson(data);                         // convierte el formato de clase SaveData a cadena
        File.WriteAllText(path, jsonFile);                                  // escribe al archivo
    }

    public void LoadPlayer()                                                // carga nombre del jugador al principio
    {
        string path = Application.persistentDataPath + "/GameData.json";    // ruta y nombre del archivo guardado para datos

        if (File.Exists(path))                                              // si el archivo existe, lo lee
        {
            string jsonFile = File.ReadAllText(path);                       // lee desde el archivo a una cadena
            SaveData data = JsonUtility.FromJson<SaveData>(jsonFile);       // convierte la cadena a formato de clase SaveData
            _player = data.PlayerData;                                      // asigna valor de playerData (clase SaveData) a _player (clase GameManager)
            _figureNum = data.FigureNumData;                                // asigna valor de figureNumData (clase SaveData) a _figureNum (clase GameManager)
        }
        else
            Debug.Log("No hay datos guardados");
    }
}

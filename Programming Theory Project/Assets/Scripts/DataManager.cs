using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    private static DataManager _manager;
    public static DataManager Manager
    {
        get { return _manager; }
        set { _manager = value; }
    }

    public Text player;             // variable, nombre del jugador
    public int figureNum;           // numero de opción de figura
    public Text figureNumText;      // FigureNum para Texto para UI

    private void Awake()
    {
        if(_manager!= null)
        {
            Destroy(gameObject);    // destruye instancias anteriores
            return;
        }
        _manager = this;            // crea la instancia
        DontDestroyOnLoad(gameObject);  // no destruye el objeto
        LoadPlayer();               // carga nombre del jugador al principio
        if(PlayerPrefs.HasKey("Ultima Figura"))
        {
            figureNum = PlayerPrefs.GetInt("Ultima Figura");
            figureNumText.text = figureNum.ToString();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public Text player;
        public Text figureText;
    }

    public void SavePlayer()
    {
        SaveData data = new SaveData();
        data.player = player; // asigna valor de player (clase DataManager) a player (clase SaveData)
        data.figureText = figureNumText; // asigna valor de figureNumText (clase DataManager) a figureText (clase SaveData)

        string path = Application.persistentDataPath + "/data.json"; // ruta y nombre de archivo guardado para persistencia de datos
        string json = JsonUtility.ToJson(data); // convierte el formato de clase SaveData a cadena
        File.WriteAllText(path, json); // escribe al archivo
    }

    public void LoadPlayer()        // carga nombre del jugador al principio
    {
        string path = Application.persistentDataPath + "/data.json"; // ruta y nombre del archivo guardado para datos

        if (File.Exists(path))  // si el archivo existe, lo lee
        {
            string json = File.ReadAllText(path); // lee desde el archivo a una cadena
            SaveData data = JsonUtility.FromJson<SaveData>(json); // convierte la cadena a formato de clase SaveData
            player = data.player; // asigna valor de player (clase SaveData) a player (clase DataManager)
            figureNumText = data.figureText; // asigna valor de figureText (clase SaveData) a figureNumText (clase DataManager)
        }
    }
}

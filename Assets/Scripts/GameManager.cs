using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// The game manager, does all the fun stuff related to it. 
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    [Header("Variables")]
    public string _playerName;
    public float _currentHealth;
    public float _maxHealth;
    public float _exp;
    public float _brosPoint;
    public float _score;
    public float _level;

    void Awake()
    {
        // Checks to see if there is already a game manager, if not it sets it to this, and if so, destorys this. 
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        if(manager != this)
        {
            Destroy(gameObject);
        }
    }

    // Displays all the stuff
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 40), "Player Name: " + _playerName);
        GUI.Label(new Rect(10, 30, 200, 40), "Health: " + _currentHealth + " / " + _maxHealth);
        GUI.Label(new Rect(10, 50, 200, 40), "BP: " + _brosPoint);
        GUI.Label(new Rect(10, 70, 200, 40), "Experience: " + _exp);
        GUI.Label(new Rect(10, 90, 200, 40), "Level: " + _level);
        GUI.Label(new Rect(10, 110, 200, 40), "Score: " + _score);
    }

    // Saves the current state of the game
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data._playerName = _playerName;
        data._currentHealth = _currentHealth;
        data._maxHealth = _maxHealth;
        data._exp = _exp;
        data._brosPoint = _brosPoint;
        data._score = _score;
        data._level = _level;

        bf.Serialize(file, data);
        file.Close();

    }

    // Loads the save that was created
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            _playerName = data._playerName;
            _currentHealth = data._currentHealth;
            _maxHealth = data._maxHealth;
            _exp = data._exp;
            _brosPoint =data._brosPoint;
            _score = data._score;
            _level = data._level;
        }
    }

    [Serializable]
    class PlayerData
    {
        [Header("Variables")]
        public string _playerName;
        public float _currentHealth;
        public float _maxHealth;
        public float _exp;
        public float _brosPoint;
        public float _score;
        public float _level;
    }

}

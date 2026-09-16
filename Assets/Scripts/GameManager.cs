using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager _manager;

    [Header("Variables")]
    [SerializeField] string _playerName;
    [SerializeField] float _currentHealth;
    [SerializeField] float _maxHealth;
    [SerializeField] float _exp;
    [SerializeField] float _brosPoint;
    [SerializeField] float _score;
    [SerializeField] float _level;

    void Awake()
    {
        if (_manager == null)
        {
            DontDestroyOnLoad(gameObject);
            _manager = this;
        }
        if(_manager != this)
        {
            Destroy(gameObject);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 40), "Player Name: " + _playerName);
        GUI.Label(new Rect(10, 30, 200, 40), "Health: " + _currentHealth + " / " + _maxHealth);
        GUI.Label(new Rect(10, 50, 200, 40), "BP: " + _brosPoint);
        GUI.Label(new Rect(10, 70, 200, 40), "Experience: " + _exp);
        GUI.Label(new Rect(10, 90, 200, 40), "Level: " + _level);
        GUI.Label(new Rect(10, 110, 200, 40), "Score: " + _score);
    }
}

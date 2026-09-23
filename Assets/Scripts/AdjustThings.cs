using UnityEngine;

public class AdjustThings : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 200, 100, 30), "Save"))
        {
            GameManager.manager.Save();
        }

        if (GUI.Button(new Rect(10, 240, 100, 30), "Load"))
        {
            GameManager.manager.Load();
        }

        GameManager.manager._playerName = GUI.TextField(new Rect(705, 10, 100, 30), GameManager.manager._playerName, 25);

        if (GUI.Button(new Rect(705, 50, 100, 30), "Health UP"))
        {
            GameManager.manager._currentHealth += 10;
            if (GameManager.manager._currentHealth > GameManager.manager._maxHealth)
            {
                GameManager.manager._currentHealth = GameManager.manager._maxHealth;
            }

        }

        if (GUI.Button(new Rect(705, 100, 100, 30), "Health DOWN"))
        {
            GameManager.manager._currentHealth -= 10;
            if (GameManager.manager._currentHealth < 0)
            {
                GameManager.manager._currentHealth = 0;
            }

        }

        if (GUI.Button(new Rect(705, 150, 100, 30), "Max UP"))
        {
            GameManager.manager._maxHealth += 10;
            GameManager.manager._currentHealth = GameManager.manager._maxHealth;
        }

        if (GUI.Button(new Rect(705, 200, 100, 30), "Max DOWN"))
        {
            GameManager.manager._maxHealth -= 10;
            GameManager.manager._currentHealth = GameManager.manager._maxHealth;
            if (GameManager.manager._maxHealth < 10)
            {
                GameManager.manager._maxHealth = 10;
                GameManager.manager._currentHealth = GameManager.manager._maxHealth;
            }
        }

        if (GUI.Button(new Rect(705, 250, 100, 30), "EXP UP"))
        {
            GameManager.manager._exp += 10;
            if (GameManager.manager._exp >= 100)
            {
                GameManager.manager._exp = 0;
                GameManager.manager._level++;
            }
        }

        if (GUI.Button(new Rect(705, 300, 100, 30), "EXP DOWN"))
        {
            GameManager.manager._exp -= 10;
            if (GameManager.manager._exp < 0)
            {
                GameManager.manager._exp = 0;
            }
        }


    }
}

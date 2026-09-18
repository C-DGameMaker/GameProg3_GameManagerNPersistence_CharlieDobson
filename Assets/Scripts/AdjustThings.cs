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

        //if (GUI.Button(new Rect(10, 200, 100, 30), "Health UP"))
        //{
        //    if (GameManager.manager._currentHealth + 10 < GameManager.manager._maxHealth)
        //    {
        //        GameManager.manager._currentHealth += 10;
        //    }
            
        //}

        //if (GUI.Button(new Rect(10, 240, 100, 30), "Health DOWN"))
        //{
        //    if (GameManager.manager._currentHealth -10 > 0)
        //    {
        //        GameManager.manager._currentHealth -= 10;
        //    }
            
        //}

        //if (GUI.Button(new Rect(10, 260, 100, 30), "Max UP"))
        //{
        //    GameManager.manager._maxHealth += 10;
        //    GameManager.manager._currentHealth = GameManager.manager._maxHealth;
        //}

        //if (GUI.Button(new Rect(10, 280, 100, 30), "EXP UP"))
        //{
        //    if (GameManager.manager._exp + 10 > 100)
        //    {
        //        GameManager.manager._exp = 0;
        //        GameManager.manager._level++;
        //    }
        //    else if (GameManager.manager._exp + 10 < 100)
        //    {
        //        GameManager.manager._exp += 10;
        //    }
            
            
        //}

        //if (GUI.Button(new Rect(10, 300, 100, 30), "EXP DOWN"))
        //{
        //    if (GameManager.manager._exp - 10 > 0)
        //    {
        //        GameManager.manager._exp -= 10;
        //    }
            

        //}


    }
}

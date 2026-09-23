using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScenes : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0); // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1); // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene(2); // press 3
        if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene(3); // press 4
    }

    private void OnGUI()
    {
        
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 80, 100, 100), "Current Scene: " + SceneManager.GetActiveScene().name);
    }
}

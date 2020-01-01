using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseMenu : MonoBehaviour
{
    public static bool Gpause = false;
    public GameObject Pmenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(Gpause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        Pmenu.SetActive(false);
        Time.timeScale = 1f;
        Gpause = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Pause()
    {
        Pmenu.SetActive(true);
        Time.timeScale = 0f;
        Gpause = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;

    }
}

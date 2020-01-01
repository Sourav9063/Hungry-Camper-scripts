using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("game2");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("menu1");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("selection level");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

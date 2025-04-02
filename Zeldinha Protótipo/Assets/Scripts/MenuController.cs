using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject creditsPainel;

    public void Teleport()
    {
        SceneManager.LoadScene("game");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitBTN()
    {
        Application.Quit();
        print("Quit");
    }
    
}

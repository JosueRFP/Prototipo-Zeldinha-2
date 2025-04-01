using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject creditsPainel;

    public void Teleport(string game)
    {
        SceneManager.LoadScene(game);
    }

    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }

    public void CloseCreditsBTN()
    {
        creditsPainel.SetActive(false);
    }

    public void QuitBTN()
    {
        Application.Quit();
        print("Quit");
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void showInicio()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void ShowMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void showEscaner()
    {
        SceneManager.LoadScene("Escaner");
    }
    public  void showJardin()
    {
        SceneManager.LoadScene("Jardin");
    }
    public void showPlanta()
    {
        SceneManager.LoadScene("Planta");
    }
}

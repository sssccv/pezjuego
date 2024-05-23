using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Controles()
    {
        SceneManager.LoadScene(2); 
    }

    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }

    public void Opciones()
    {
        SceneManager.LoadScene(4);
    }
    public void cuatrojugadores()
    {
        SceneManager.LoadScene(5);
    }
    public void mododejuego()
    {
        SceneManager.LoadScene(6);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

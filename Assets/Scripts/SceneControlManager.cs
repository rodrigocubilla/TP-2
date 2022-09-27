using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControlManager : MonoBehaviour
{
    public string nomEscena;

    public void CargarEscena()
    {
        SceneManager.LoadScene(nomEscena);
    }
    public void SalirDeJuego()
    {
        Application.Quit();
    }
}

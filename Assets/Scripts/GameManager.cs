using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void VolverAJugar()
    {
        SceneManager.LoadScene("mazeEscape");
    }
    public void EmpezarAJugar()
    {
        SceneManager.LoadScene("mazeEscape");
    }
    public void SalirDelJuego()
    {
        SceneManager.LoadScene("inicio");
        Application.Quit();
    }

    public void IrAOpciones()
    {
        SceneManager.LoadScene("opciones");
    }

   public void IrACreditos()
    {
        SceneManager.LoadScene("creditos");
    }

    public void IrMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}


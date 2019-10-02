using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botton : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("lingkungan");
    }
    public void Back()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public  void Quitbtn()
    {
        SceneManager.LoadScene("ValidationScene");
    }

    public void Rematch()
    {

            SceneManager.LoadScene("GamePlayScene");      
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Application closed");
            Application.Quit();
        }
    }
    public void Galery()
    {
        SceneManager.LoadScene("GaleryScene");
    }
    public void Yesbtn()
    {
        Debug.Log("Application closed");
        Application.Quit();
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Application closed");
            Application.Quit();
        }
    }
}

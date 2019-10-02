using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botton : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("PilihStartScene");
    }
        public void Story()
        {
            SceneManager.LoadScene("StoryScene");
        }
        
            public void Stage1()
            {
                SceneManager.LoadScene("KulitScene");
            }
        public void SideQuest()
        {
        SceneManager.LoadScene("SideQuestScene");
        }

    public void Option()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void Galery()
    {
        SceneManager.LoadScene("GaleryScene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("ValidationScene");
    }

         public void No()
         {
             SceneManager.LoadScene("MenuScene");
         }
        public void Yes()
         {
             Debug.Log("Application closed");
             Application.Quit();
             if (Input.GetKeyUp(KeyCode.Escape))
                {
                    Debug.Log("Application closed");
                    Application.Quit();
                }
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
   
    
    
   
}

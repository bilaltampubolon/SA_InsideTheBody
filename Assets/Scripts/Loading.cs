using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
   [SerializeField] private float delayLoading = 3f;
   [SerializeField] private string MenuScene;
   private float timeElapsed;

   private void Update()
   {
       timeElapsed += Time.deltaTime;

       if (timeElapsed > delayLoading)
       {
           SceneManager.LoadScene(MenuScene);
       }
   }
}

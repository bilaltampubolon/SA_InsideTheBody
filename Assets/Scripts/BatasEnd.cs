using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasEnd : MonoBehaviour
{
  public  void Rematch()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("GameOverScene");
    }

   
}

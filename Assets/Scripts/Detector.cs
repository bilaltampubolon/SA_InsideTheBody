using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detector : MonoBehaviour
{
    public int HP = 3;
    public string nameTag;
    public AudioClip Benar;
    public AudioClip Salah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    void Start()
    {
       MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
       MediaPlayerBenar.clip =  Benar; 

       MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
       MediaPlayerSalah.clip = Salah;
    }

    //void /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="collision">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            // Score.score += 10;
            //textScore.text = Score.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
            HP -= 1;
        }
        else
        {
            //Score.score -= 5;
            // textScore.text = Score.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
    void Update()
    {
        
    }
}

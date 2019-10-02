 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruControl : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
            return;
        if (col.gameObject.CompareTag("Enemy2"))
        {
            col.gameObject.SendMessage("TakeDamage", 1);
        }
        Destroy(this.gameObject);
    }
}
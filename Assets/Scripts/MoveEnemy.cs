using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] Sampah2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, Sampah2.Length);
            Instantiate(Sampah2[random], transform.position, transform.rotation);
            timer=0;
        }
    }
}

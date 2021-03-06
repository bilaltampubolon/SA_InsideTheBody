﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rigid;

    Animator anim;

    public int HP = 1;
    bool isDie = false;
   void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            isDie = true;
            rigid.velocity = Vector2.zero;
            anim.SetBool("IsDie", true);
            Destroy(this.gameObject, 2);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("player"))
        {
            print("Players is hits");
            col.gameObject.SendMessage("DamageTake", 1);
        }
        Destroy(this.gameObject);
    }
}

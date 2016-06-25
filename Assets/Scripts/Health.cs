﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
    public float health;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            //optionally trigger Die Animation
            DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
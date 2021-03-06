﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float maxDistance = 7f;
    private float distanceTravelled = 0f;
    private Vector2 lastPosition;
    private Player player;

    // Use this for initialization
    void Start()
    {
        lastPosition = transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {
        distanceTravelled += Vector2.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        if (distanceTravelled > maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Player") || col.CompareTag("Bullet") || col.CompareTag("Checkpoint") || col.CompareTag("Item")){
            // Do Nothing
        }
        else {
            if (col.CompareTag("Enemy") || col.CompareTag("Boss"))
            {
                col.SendMessage("Damage", player.damage);
            }
            Destroy(gameObject);
        }
    }
}

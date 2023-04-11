using System;
using System.Collections;
using System.Collections.Generic;
using FlappyBird.Enevironment;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Missile : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource missleSound;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        missleSound = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        missleSound.Play();
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * (400f * Time.deltaTime));
    }

    private void Update()
    {
        if(transform.position.x >= 12f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Seagull seagull = col.GetComponent<Seagull>();
        
        if(seagull != null)
        {
            SoundManager.Instance.PlaySound(3);
            missleSound.Stop();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}

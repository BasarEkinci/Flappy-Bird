using System;
using System.Collections;
using System.Collections.Generic;
using FlappyBird.Managers;
using UnityEngine;

public class Mountain : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Instance.IsGameOver) return;
        
        transform.position += Vector3.left * (3 * Time.deltaTime);
        if (transform.position.x <= -12f)
        {
            transform.position = new Vector3(12, transform.position.y, 0);
        }
    }
}

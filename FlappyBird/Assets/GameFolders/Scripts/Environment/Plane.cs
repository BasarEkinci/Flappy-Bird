using System.Collections;
using System.Collections.Generic;
using FlappyBird.Managers;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private float moveSpeed = 4f;
    void Update()
    {
        if (GameManager.Instance.IsGameOver) return;
        
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        if (transform.position.x <= -18.34f)
        {
            transform.position = new Vector3(-0.35f,transform.position.y,0);
        }
    }
}

using System;
using FlappyBird.Managers;
using UnityEngine;

namespace FlappyBird.Player
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rb;
        [SerializeField] private float jumpForce;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            rb.simulated = false;
        }

        private void Update()
        {
            if (GameManager.Instance.IsGameOver || !GameManager.Instance.IsGameStart) return;
        
            if (Input.GetKeyDown(KeyCode.Space))
                Jump();
        }
        private void Jump()
        {
            rb.simulated = true;
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
            SoundManager.Instance.PlaySound(0);
        }
    }    
}
    



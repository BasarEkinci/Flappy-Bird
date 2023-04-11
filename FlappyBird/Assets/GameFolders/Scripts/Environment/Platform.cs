using FlappyBird.Managers;
using FlappyBird.Player;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float moveSpeed = 4f;
    private void Update()
    {
        if (GameManager.Instance.IsGameOver) return;
        
        if (transform.position.x <= -9.5f)
        {
            GameManager.Instance.Score++;
            SoundManager.Instance.PlaySound(2);
            Destroy(gameObject);
        }
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col) 
    { 
        PlayerController player = col.collider.GetComponent<PlayerController>();
        
        if (player != null)
        {
            player.GetComponent<Collider2D>().isTrigger = true;
            GameManager.Instance.GameOver();
        }
    }
}



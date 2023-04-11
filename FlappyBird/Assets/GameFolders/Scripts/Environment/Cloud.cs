using FlappyBird.Managers;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cloud : MonoBehaviour
{
    private Vector3 spawnPos;
    private void Update()
    {
        if (GameManager.Instance.IsGameOver) return;
        
        transform.position += Vector3.left * (2f * Time.deltaTime);
        if (transform.position.x <= -12f)
        {
            transform.position = new Vector3(12, Random.Range(0, 4f), 0);
        }
    }
}

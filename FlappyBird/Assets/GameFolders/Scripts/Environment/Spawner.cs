using FlappyBird.Managers;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject seagull;
    private Vector3 spawnPos;
    private float spawnRate;
    private void Start()
    {
        InvokeRepeating(nameof(SpawnPlatform),1,1.5f);
    }

    private void SpawnPlatform()
    {
        if (GameManager.Instance.IsGameOver || !GameManager.Instance.IsGameStart) return;
        
        spawnPos = new Vector3(10.5f, Random.Range(-1.1f, 2.9f), 0);
        Instantiate(platform, spawnPos, transform.rotation);
        SpawnSeagull();
    }

    private void SpawnSeagull()
    {
        int rnd = Random.Range(0, 11);
        if(rnd < 2)
            Instantiate(seagull, spawnPos, transform.rotation);
    }
}

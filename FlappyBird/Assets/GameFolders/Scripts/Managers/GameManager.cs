using UnityEngine;
using UnityEngine.SceneManagement;

namespace FlappyBird.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public int Score { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsGameStart { get; set; }
    
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else
                Destroy(gameObject);
        }
    
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsGameStart = true;
            }
        }
    
        private void Start()
        {
            IsGameStart = false;
            IsGameOver = false;
        }
        public void GameOver()
        {
            IsGameOver = true;
            SoundManager.Instance.PlaySound(4);
            Debug.Log("Game Over");
        }
        public void RestartGame()
        {
            IsGameStart = false;
            IsGameOver = false;
            SceneManager.LoadScene(0);
            Score = 0;
        }
    }    
}



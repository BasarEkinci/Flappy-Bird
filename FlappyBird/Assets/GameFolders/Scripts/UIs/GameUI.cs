using FlappyBird.Managers;
using TMPro;
using UnityEngine;

namespace FlappyBird.UIs
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text scoreText2;
        [SerializeField] private TMP_Text startText;
        [SerializeField] private GameObject gameOverPanel;
    
        private void Start()
        {
            gameOverPanel.SetActive(false);
        }
        private void Update()
        {
            scoreText.text = (GameManager.Instance.Score).ToString("0");
            
            GameOverActions();
            StartGame();
        }
    
        private void StartGame()
        {
            if(!GameManager.Instance.IsGameStart)
            {
                startText.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(false);
            }
            else
            {
                startText.gameObject.SetActive(false);
                scoreText.gameObject.SetActive(true);
            }
        }
        public void RestartButton()
        {
            GameManager.Instance.RestartGame();
            gameOverPanel.SetActive(false);
        }
        private void GameOverActions()
        {
            if(GameManager.Instance.IsGameOver)
            {
                gameOverPanel.SetActive(true);
                scoreText2.text = "\nScore\n" + GameManager.Instance.Score.ToString("0");
                scoreText.gameObject.SetActive(false);
            }
            else
            {
                gameOverPanel.SetActive(false);
                scoreText.gameObject.SetActive(true);
            }
        }
    }    
}


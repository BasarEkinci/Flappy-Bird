using UnityEngine;
using DG.Tweening;
using FlappyBird.Managers;
using FlappyBird.Player;

namespace FlappyBird.Enevironment
{
    public class Seagull : MonoBehaviour
    {
        private void Start()
        {
            transform.DOMoveY(transform.position.y + 1, 0.5f, false).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        }

        private void OnEnable()
        {
            SoundManager.Instance.PlaySound(1);
        }

        private void Update()
        {
            transform.position += Vector3.left * (7 * Time.deltaTime);
            if(transform.position.x <= -12f)
                Destroy(gameObject);
        }
        private void OnTriggerEnter2D(Collider2D col)
        {
            PlayerController player = col.GetComponent<PlayerController>();

            if (player != null)
            {
                GameManager.Instance.GameOver();
                Destroy(gameObject);
            }
        }
    }    
}


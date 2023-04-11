using System;
using UnityEngine;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using Debug = System.Diagnostics.Debug;

namespace FlappyBird.UIs.UIAnimations
{
    public class TextAnimation : MonoBehaviour
    {
        private void OnEnable()
        {
            transform.DOScale(new Vector3(0.9f, 0.9f, 1f), 0.5f).SetLoops(-1, LoopType.Yoyo);
        }
    }    
}



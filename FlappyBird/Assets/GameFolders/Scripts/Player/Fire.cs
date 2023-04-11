using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fire : MonoBehaviour
{
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject missile;

    private float coolDownTime = 3f;
    private float nextFireTime = 0f;
    
    void Update()
    {
        if(Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Instantiate(missile, firePos.position, transform.rotation);
                nextFireTime = Time.time + coolDownTime;
            }
        }
    }
}

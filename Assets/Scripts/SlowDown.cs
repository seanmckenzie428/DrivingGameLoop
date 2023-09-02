using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public float slowDownAmount = 100;

    private void OnTriggerEnter(Collider other)
    {
    
            SimpleCarController car = other.GetComponent<SimpleCarController>();
            if (car != null)
            {
                car.SlowDown(slowDownAmount);
            }
    }
}

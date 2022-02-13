using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float timer = 1f;
    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if(timer <= 0) {
            Destroy(gameObject);
        }
    }
}

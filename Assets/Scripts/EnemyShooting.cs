using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPreFab;
    float cooldownTimer = 0;
    public float fireDelay = 0.25f;
    // Update is called once per frame
    void FixedUpdate() {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0) {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPreFab, transform.position + offset, transform.rotation);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacesPlayer : MonoBehaviour
{
    public float rotSpeed = 180f;
    Transform player;

    void FixedUpdate() {
       if(player == null) {
            GameObject go = GameObject.FindWithTag("Player");

            if(go != null) {
                player = go.transform;
            }
        }
        if (player == null)
            return;

        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }
}

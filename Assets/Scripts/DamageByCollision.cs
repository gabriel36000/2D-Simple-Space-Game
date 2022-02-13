using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByCollision : MonoBehaviour
{
    public int health = 1;
    void OnTriggerEnter2D(Collider2D collision) {
        health--;
        if (collision.gameObject.tag == "PlayerBullet") {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "EnemyBullet") {
            Destroy(collision.gameObject);
        }
    }
    void Die() {
        Destroy(gameObject);
    }

    private void FixedUpdate() {
        if (health <= 0) {
            Die();
        }
    }
}

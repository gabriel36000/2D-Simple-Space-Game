using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageByCollision : MonoBehaviour
{
    public int health;
    public Slider healthBar;
    public GameObject Enemy;
    private void Start() {
        healthBar.maxValue = health;
        healthBar.value = health;
    }
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
        Destroy(Enemy);
    }

    private void FixedUpdate() {
        healthBar.value = health;
        if (health <= 0) {
            Die();
        }

    }
}

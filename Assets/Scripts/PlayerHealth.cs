using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Slider healthBar;
    public TMP_Text currentHealth;
    

    private void Start() {
        currentHealth = GameObject.FindGameObjectWithTag("Health").GetComponent<TMP_Text>();
        healthBar = GameObject.FindGameObjectWithTag("healthslider").GetComponent<Slider>();
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
        Destroy(gameObject);
    }

    private void FixedUpdate() {
        currentHealth.text = health.ToString() + "/" + healthBar.maxValue;
        healthBar.value = health;
        if (health <= 0) {
            Die();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPreFab;
    GameObject playerInstance;
    public int numLives = 3;

    float respawnTimer = 1;

     void Start() {
        playerInstance = (GameObject)Instantiate(playerPreFab, transform.position, Quaternion.identity);

    }
    void SpawnPlayer() {
        numLives--;
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPreFab, transform.position, Quaternion.identity);
    }

     void FixedUpdate() {
        if(playerInstance == null && numLives > 0) {
            respawnTimer -= Time.deltaTime;

            if(respawnTimer <= 0) {
                SpawnPlayer();
            }
        }
    }
    private void OnGUI() {
        if (numLives > 0 || playerInstance != null) {
            GUI.Label(new Rect(0, 0, 100, 50), "Lives: " + numLives);
        }
        else {
            GUI.Label(new Rect( Screen.width/2 - 50, Screen.height, 100, 50), "Game Over!");
        }
    }
}

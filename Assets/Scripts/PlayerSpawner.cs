using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPreFab;
    GameObject playerInstance;

    float respawnTimer = 1;

     void Start() {
        playerInstance = (GameObject)Instantiate(playerPreFab, transform.position, Quaternion.identity);

    }
    void SpawnPlayer() {
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPreFab, transform.position, Quaternion.identity);
    }

     void FixedUpdate() {
        if(playerInstance == null) {
            respawnTimer -= Time.deltaTime;

            if(respawnTimer <= 0) {
                SpawnPlayer();
            }
        }
    }
}

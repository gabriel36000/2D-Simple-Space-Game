using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public Transform transformHealthBar;
    private void Update() {
        if (transformHealthBar) {
            transform.position = transformHealthBar.transform.position;
        }
    }
}

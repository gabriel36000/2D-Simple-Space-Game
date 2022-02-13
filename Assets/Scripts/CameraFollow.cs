using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform myTarget;

    void Start() {

        myTarget = GameObject.FindWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        myTarget = GameObject.FindWithTag("Player").transform;
        if (myTarget != null) {
            Vector3 targetPos = myTarget.position;
            targetPos.z = transform.position.z;
            transform.position = targetPos;
        }
    }
    
}

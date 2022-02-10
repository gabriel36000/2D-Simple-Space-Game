using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinpleMoving : MonoBehaviour
{
    public float maxSpeed;
    public float rotationSpeed;

    float shipBoundaryRadius = -5f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate() {

        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;

        



        transform.position = pos;
    }
}

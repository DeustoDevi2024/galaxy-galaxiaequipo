using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Transform centerObject; 
    public float orbitSpeed = 1f; 
    public float rotationSpeed = 10f;

    private Vector3 axisOfRotation; // eje

    void Start()
    {
        axisOfRotation = Vector3.up;
    }

    void Update()
    {
        transform.RotateAround(centerObject.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(axisOfRotation, rotationSpeed * Time.deltaTime);
    }
}

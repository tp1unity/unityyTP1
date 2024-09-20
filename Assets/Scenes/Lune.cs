using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lune : MonoBehaviour
{
    public Transform center;   // Centre autour duquel la lune va tourner (Terre)
    public float orbitSpeed = 15f; // Vitesse d'orbite
    public float rotationSpeed = 25f;

    void Update()
    {

        transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);


        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

}

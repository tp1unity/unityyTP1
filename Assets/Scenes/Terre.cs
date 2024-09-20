using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terre : MonoBehaviour
{
    public Transform center;   // Centre autour duquel la planète va tourner
    public float orbitSpeed = 10f;

    // Vitesse de rotation sur soi-même
    public float rotationSpeed = 25f;

    void Update()
    {
        // Rotation autour du centre (Soleil pour la Terre, Terre pour la Lune)
        transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Rotation sur soi-même
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}

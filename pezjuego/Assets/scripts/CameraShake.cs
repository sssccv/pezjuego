using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform; // Referencia al transform de la cámara
    public float shakeIntensity = 0.1f; // Intensidad de la sacudida

    private Vector3 originalPosition; // Posición original de la cámara

    void Start()
    {
        originalPosition = cameraTransform.position;
    }

    void Update()
    {
        // Genera una posición aleatoria dentro de un radio definido
        Vector3 randomOffset = Random.insideUnitSphere * shakeIntensity;
        cameraTransform.position = originalPosition + randomOffset;
    }
}

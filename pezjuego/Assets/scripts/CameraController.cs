using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform[] waypoints; // Los puntos a los que la cámara se moverá
    public float transitionTime = 0.5f; // Tiempo de transición entre puntos
    public Transform target1; // El primer objetivo (personaje) al que la cámara debe mirar

    private int currentWaypointIndex = 0;
    private float transitionTimer = 0f;
    private bool isLookingAtFirstTarget = true; // Indica si la cámara está mirando al primer objetivo
    private Vector3 velocity = Vector3.zero; // Velocidad utilizada por SmoothDamp

    void Update()
    {
        // Actualiza el temporizador de transición
        transitionTimer += Time.deltaTime;

        // Si el temporizador supera el tiempo de transición, cambia al siguiente punto
        if (transitionTimer >= transitionTime)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            transitionTimer = 0f;
        }

        // Mueve la cámara hacia el punto actual utilizando SmoothDamp
        transform.position = Vector3.SmoothDamp(transform.position, waypoints[currentWaypointIndex].position, ref velocity, transitionTime);

        // Asegura que la cámara mire hacia el objetivo correspondiente
        if (isLookingAtFirstTarget)
        {
            transform.LookAt(target1);
        }
    }
}

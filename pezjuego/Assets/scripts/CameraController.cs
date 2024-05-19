using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform[] waypoints; // Los puntos a los que la c�mara se mover�
    public float transitionTime = 0.5f; // Tiempo de transici�n entre puntos
    public Transform target1; // El primer objetivo (personaje) al que la c�mara debe mirar
   
    private int currentWaypointIndex = 0;
    private float transitionTimer = 0f;
    private bool isLookingAtFirstTarget = true; // Indica si la c�mara est� mirando al primer objetivo

    void Update()
    {
        // Actualiza el temporizador de transici�n
        transitionTimer += Time.deltaTime;

        // Si el temporizador supera el tiempo de transici�n, cambia al siguiente punto
        if (transitionTimer >= transitionTime)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            transitionTimer = 0f;
            
        }

        // Mueve la c�mara hacia el punto actual
        transform.position = Vector3.Lerp(transform.position, waypoints[currentWaypointIndex].position, transitionTimer / transitionTime);

        // Asegura que la c�mara mire hacia el objetivo correspondiente
        if (isLookingAtFirstTarget)
        {
            transform.LookAt(target1);
        }
       
    }
}

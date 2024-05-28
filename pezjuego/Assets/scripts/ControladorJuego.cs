using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;
    
    public GameObject Desactivar2;
    public GameObject Desactivar3;
    public GameObject Desactivar4;
    public GameObject Desactivar5;
    public GameObject Desactivar6;
    public GameObject Desactivar7;
    public GameObject Activar;
    public GameObject Activarpescador;

    public BarraDeVida barraDeVida;

    private float tiempoActual;

    private bool tiempoActivado = false;


    private void Start()
    {
        ActivarTemporizador();
    }

    private void Update()
    {
        if (tiempoActivado)
        {
            CambiarContador();
        }
    }
    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual >= 0)
        {
            slider.value = tiempoActual;
        }
        if (tiempoActual <= 0)
        {
            Debug.Log("Tiempo acabado");
            CambiarTemporizador(false);
            
             // El objeto se deshabilita
            Desactivar2.SetActive(false);
            Desactivar3.SetActive(false);
            Desactivar4.SetActive(false);
            Desactivar5.SetActive(false);
            Desactivar6.SetActive(false);
            Desactivar7.SetActive(false);
            // El objeto se habilita

            if (barraDeVida != null && barraDeVida.vidaactual < 50)
            {
                Activar.SetActive(true); // El objeto se habilita
            }

            if (barraDeVida != null && barraDeVida.vidaactual > 50)
            {
                Activarpescador.SetActive(true); // El objeto se habilita
            }
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }

    public void ActivarTemporizador()
    {
        tiempoActual = tiempoMaximo;
        slider.maxValue = tiempoMaximo;
        CambiarTemporizador(true);

    }
    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }

}

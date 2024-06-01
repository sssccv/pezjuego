using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlador4J : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;

    public GameObject Desactivar2;
    public GameObject Desactivar3;
    public GameObject Desactivar4;
    public GameObject Desactivar5;
    public GameObject Desactivar6;



    public barravida4jug barravida4Jug;

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

            // El objeto se habilita

            if (barravida4Jug != null && barravida4Jug.vidaactual < 50)
            {

                SceneManager.LoadScene(8);
            }

            if (barravida4Jug != null && barravida4Jug.vidaactual > 50)
            {

                SceneManager.LoadScene(9);
            }
            if (barravida4Jug != null && barravida4Jug.vidaactual == 50)
            {

                SceneManager.LoadScene(5);
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

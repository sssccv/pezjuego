using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual;
    public float vidaM�xima;
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaM�xima;
    }
}

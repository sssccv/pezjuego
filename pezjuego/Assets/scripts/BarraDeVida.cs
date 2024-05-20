using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image barradevida;
    public float vidaactual;
    public float vidamaxima;
    public float modvida;
    void Update()
    {
        barradevida.fillAmount = vidaactual/vidamaxima;
        if (Input.GetKeyDown(KeyCode.J))
        {
            vidaactual = vidaactual+modvida;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            vidaactual = vidaactual - modvida;
        }
        if(vidaactual>=vidamaxima)
        {
            vidaactual = vidamaxima;
        }
        if (vidaactual <= 0)
        {
            vidaactual = 0;
            Debug.Log("Derrota");
        }
    }
    
}

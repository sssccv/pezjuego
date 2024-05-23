using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barravida4jug : MonoBehaviour
{
    public Image barradevida;
    public float vidaactual;
    public float vidamaxima;
    public float modvida;
    void Update()
    {
        barradevida.fillAmount = vidaactual / vidamaxima;
        if (Input.GetKeyDown(KeyCode.A))
        {
            vidaactual = vidaactual + modvida;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            vidaactual = vidaactual + modvida;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            vidaactual = vidaactual - modvida;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            vidaactual = vidaactual - modvida;
        }
        if (vidaactual >= vidamaxima)
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

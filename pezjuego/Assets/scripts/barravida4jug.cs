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
        if (Input.GetKeyDown(KeyCode.Joystick1Button18))
        {
            vidaactual = vidaactual + modvida;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button16))
        {
            vidaactual = vidaactual + modvida;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button17))
        {
            vidaactual = vidaactual - modvida;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button19))
        {
            vidaactual = vidaactual - modvida;
        }
        if (vidaactual >= vidamaxima)
        {
            vidaactual = vidamaxima;
        }
        if (vidaactual <= 49.99)
        {
            Debug.Log("el pescador anda ganando");

        }

        if (vidaactual >= 50.1)
        {
            
            Debug.Log("el pescao anda ganando");

        }

        if(vidaactual <=0)
        {
            vidaactual = 0;
        }
        
    }

}

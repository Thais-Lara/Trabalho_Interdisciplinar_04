using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Colisao : MonoBehaviour
{
    public Text UIVidas;
    int vidas = 5;


    void OnTriggerEnter(Collider colidido)
    {
        if (colidido.gameObject.CompareTag("Enemy") == true)
        {

            vidas--;

            if (vidas == 0)
            {
                Time.timeScale = 0f;
            }
        }
    }

}

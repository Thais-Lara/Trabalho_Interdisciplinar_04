using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharJogo : MonoBehaviour
{


    public void Fechar()
    {
        
        if (Input.GetMouseButton(0))
        {
            Application.Quit();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsuario = 0;
    public Text myText;

    void Start()
    {
        if(edadUsuario >= 18)
        {
            myText.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            myText.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MostrarSalida : MonoBehaviour
{

    public Image BG_Salir;
    public TextMeshProUGUI Titulo;
    public TextMeshProUGUI Subtitulo;

    public Image Cancelar;
    public TextMeshProUGUI Txt_Cancelar;

    public Image Salir;
    public TextMeshProUGUI Txt_Salir;



    bool activo = false;

    void Start()
    {
        //inhabilitar BG y Botones
        BG_Salir.enabled = false;
        Cancelar.enabled = false;
        Salir.enabled = false;

        // inhabilitar textos
        Titulo.enabled = false;
        Subtitulo.enabled = false;
        Txt_Cancelar.enabled = false;
        Txt_Salir.enabled = false;

    }

    void Update()
    {
        
    }

    public void salir() 
    { 
        activo = !activo;

        if (activo)
        {
            //Habilitar BG y Botones
            BG_Salir.enabled = true;
            Cancelar.enabled = true;
            Salir.enabled = true;

            //Habilitar textos
            Titulo.enabled = true;
            Subtitulo.enabled = true;
            Txt_Cancelar.enabled = true;
            Txt_Salir.enabled = true;

        }

        else 
        {
            //inhabilitar BG y Botones
            BG_Salir.enabled = false;
            Cancelar.enabled = false;
            Salir.enabled = false;

            // inhabilitar textos
            Titulo.enabled = false;
            Subtitulo.enabled = false;
            Txt_Cancelar.enabled = false;
            Txt_Salir.enabled = false;

        }

    }
}

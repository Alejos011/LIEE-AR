using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnableDisableRV : MonoBehaviour
{
    //objetos tipo Image
    public Image Bg_salir;
    public Image Btn_cancelar;
    public Image Btn_salir;

    //objetos tipo TextMesh
    public TextMeshProUGUI Txt_titulo;
    public TextMeshProUGUI Txt_subtitulo;
    public TextMeshProUGUI Txt_cancelar;
    public TextMeshProUGUI Txt_salir;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //habilitar pop up de confirmación de salida 
    public void EnableExitBgRV()
    {
        Bg_salir.enabled = true;
        Btn_cancelar.enabled = true;
        Btn_salir.enabled = true;

        Txt_titulo.enabled = true;
        Txt_subtitulo.enabled = true;
        Txt_cancelar.enabled = true;
        Txt_salir.enabled = true;
    }

    //deshabilitar pop up de confirmación de salida 
    public void DisableExitBgRV()
    {
        Bg_salir.enabled = false;
        Btn_cancelar.enabled = false;
        Btn_salir.enabled = false;

        Txt_titulo.enabled = false;
        Txt_subtitulo.enabled = false;
        Txt_cancelar.enabled = false;
        Txt_salir.enabled = false;
    }
}


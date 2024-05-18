using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnableDisable : MonoBehaviour
{
    //Objetos tipo TextMesh
    public TextMeshProUGUI Dialogos;
    public TextMeshProUGUI TituloComenzar;
    public TextMeshProUGUI CancelarComienzo;

    public TextMeshProUGUI Comenzar;
    public TextMeshProUGUI Continuar;
    public TextMeshProUGUI Terminar;

    public TextMeshProUGUI TituloTerminar;
    public TextMeshProUGUI Txt_terminar;
    public TextMeshProUGUI Txt_CancelarTerminar;

    // objetos de tipo image
    public Image Dialogo;
    public Image Btn_next;
    public RawImage next;

    public Image Btn_back;
    public RawImage back;

    public Image ComenzarRA;
    public Image CancelarRA;
    public Image ComenzarExp;

    public Image Btn_Continuar;
    public Image Btn_Terminar;

    public Image TerminarRA;
    public Image CancelarTerminar;
    public Image ConfirmarTerminar;

    //GameObjects a modificar (capys)

    public GameObject CapyLunchIzquierda;
    public GameObject CapyLunchDerecha;

    public GameObject CapyNerdIzquierda;
    public GameObject CapyNerdDerecha;

    public GameObject CaparpadeoIzquierda;
    public GameObject CaparpadeoDerecha;

    public GameObject CapyCartoonIzquierda;
    public GameObject CapyCartoonDerecha;

    public GameObject CapyNojaoIzquierda;
    public GameObject CapyNojaoDerecha;

    //Objetos de tipo audio

    public AudioSource ClipActual;

    //Esfera
    public AudioClip Esfera_D1;
    public AudioClip Esfera_D2;
    public AudioClip Esfera_D3;
    public AudioClip Esfera_D4;
    public AudioClip Esfera_D5;
    public AudioClip Esfera_D6;
    public AudioClip Esfera_D7;
    public AudioClip Esfera_D8;

    //Choque
    public AudioClip Choque_D1;
    public AudioClip Choque_D2;
    public AudioClip Choque_D3;
    public AudioClip Choque_D4;
    public AudioClip Choque_D5;
    public AudioClip Choque_D6;

    //Conmutación
    public AudioClip Conmu_D1;
    public AudioClip Conmu_D2;
    public AudioClip Conmu_D3;
    public AudioClip Conmu_D4;
    public AudioClip Conmu_D5;

    //Fotogoniómetro
    public AudioClip Foto_D1;
    public AudioClip Foto_D2;
    public AudioClip Foto_D3;
    public AudioClip Foto_D4;
    public AudioClip Foto_D5;
    public AudioClip Foto_D6;

    //Sobretensiones
    public AudioClip Sobre_D1;
    public AudioClip Sobre_D2;
    public AudioClip Sobre_D3;
    public AudioClip Sobre_D4;
    public AudioClip Sobre_D5;
    public AudioClip Sobre_D6;
    public AudioClip Sobre_D7;
    public AudioClip Sobre_D8;


    //Deshabilitar el pop-up de término de un recorrido
    public void DisableFinishImage()
    {
        TituloTerminar.enabled = false;
        Txt_CancelarTerminar.enabled = false;
        Txt_terminar.enabled = false;
        TerminarRA.enabled = false;
        CancelarTerminar.enabled = false;
        ConfirmarTerminar.enabled = false;
    }

    public void EnableFinishImage()
    {
        TituloTerminar.enabled = true;
        Txt_CancelarTerminar.enabled = true;
        Txt_terminar.enabled = true;
        TerminarRA.enabled = true;
        CancelarTerminar.enabled = true;
        ConfirmarTerminar.enabled = true;
    }


    //Deshabilitar el pop-up de comenzar recorrido
    public void DisableStartImage()
    {
        ComenzarRA.enabled = false;
        CancelarRA.enabled = false;
        ComenzarExp.enabled = false;
        TituloComenzar.enabled = false;
        CancelarComienzo.enabled = false;
        Comenzar.enabled = false;

    }

    //Habilitar el pop-up de comenzar recorrido
    public void EnableStartImage()
    {
        ComenzarRA.enabled = true;
        CancelarRA.enabled = true;
        ComenzarExp.enabled = true;
        TituloComenzar.enabled = true;
        CancelarComienzo.enabled = true;
        Comenzar.enabled = true;
    }

    //Deshabilitar botón de continuar
    public void DisableContinueButton()
    {
        Btn_Continuar.enabled = false;
        Continuar.enabled = false;
    }

    //Habilitar botón de continuar
    public void EnableContinueButton()
    {
        Btn_Continuar.enabled = true;
        Continuar.enabled = true;
    }

    //Deshabilitar botón de Terminar
    public void DisableFinishButton()
    {
        Btn_Terminar.enabled = false;
        Terminar.enabled = false;
    }
    //Habilitar botón de Terminar
    public void EnableFinishButton()
    {
        Btn_Terminar.enabled = true;
        Terminar.enabled = true;
    }

    //Deshabilitar botón de Retroceso de dialogos
    public void DisableBackButton()
    {
        Btn_back.enabled = false;
        back.enabled = false;
    }

    //Habilitar botón de Retroceso de dialogos
    public void EnableBackButton()
    {
        Btn_back.enabled = true;
        back.enabled = true;
    }

    //Deshabilitar botón de Siguiente de dialogos
    public void DisableNextButton()
    {
        Btn_next.enabled = false;
        next.enabled = false;
    }

    //Habilitar botón de Siguiente de dialogos
    public void EnableNextButton()
    {
        Btn_next.enabled = true;
        next.enabled = true;
    }

    //Habilitar objeto de capy predeterminado para la escena 1
    public void EnableDefaultCapysImage()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(true);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }

    //Deshabilitar todos los capys
    public void DisableAllCapysImages()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);

    }

    //Habilitar solo capyLunchIzquierda

    public void EnableLeftCapyLunchOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(true);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);

    }

    public void EnableRightCapyLunchOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(true);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }

    public void EnableLeftCapyNerdOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(true);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }

    public void EnableRightCapyNerdOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(true);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }

    public void EnableLeftCaparpadeoOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(true);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }

    public void EnableRightCaparpadeoOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(true);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }

    public void EnableLeftCapyCartoonOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(true);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }
    public void EnableRightCapyCartoonOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(true);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(false);
    }
    public void EnableLeftCapyNojaoOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(true);
        CapyNojaoDerecha.SetActive(false);
    }
    public void EnableRightCapyNojaoOnly()
    {
        //Capys lunch
        CapyLunchIzquierda.SetActive(false);
        CapyLunchDerecha.SetActive(false);

        //Capys Nerdos
        CapyNerdIzquierda.SetActive(false);
        CapyNerdDerecha.SetActive(false);

        //Capys parpadeando
        CaparpadeoIzquierda.SetActive(false);
        CaparpadeoDerecha.SetActive(false);

        //Capys con libro mamañemazos
        CapyCartoonIzquierda.SetActive(false);
        CapyCartoonDerecha.SetActive(false);

        //Capys enojaos
        CapyNojaoIzquierda.SetActive(false);
        CapyNojaoDerecha.SetActive(true);
    }

    public void VoiceManager(AudioClip Clip)
    {
        ClipActual.clip = Clip;
        ClipActual.Play();
    }

}

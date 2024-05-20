using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSecuence : MonoBehaviour
{

    //GameObjects para modificar sus estados
    public GameObject BotExpand;
    public GameObject TopExpand;
    public GameObject Btn_Plus;
    public GameObject Btn_Expanded;
    public GameObject Txt_Bienvenida;
    public GameObject Instrucciones;
    void Start()
    {
        //Deshabilitar animaciones al inicio de la escena
        StartingLabRouteAnimationsDisabled();

    }

    //Deshabilitar animaciones de inicio de ruta RV
    private void StartingLabRouteAnimationsDisabled()
    {
        Animator BotAnimator = BotExpand.GetComponent<Animator>();
        Animator TopAnimator = TopExpand.GetComponent<Animator>();
        Animator PlusAnimator = Btn_Plus.GetComponent<Animator>();
        Animator ExpandedAnimator = Btn_Expanded.GetComponent<Animator>();
        Animator BienvenidaAnimator = Txt_Bienvenida.GetComponent<Animator>();
        Animator InstruccionesAnimator = Instrucciones.GetComponent<Animator>();
        BotAnimator.enabled = false;
        TopAnimator.enabled = false;
        PlusAnimator.enabled = false;
        ExpandedAnimator.enabled = false;
        BienvenidaAnimator.enabled = false;
        InstruccionesAnimator.enabled = false;
    }

    //Habilitar animaciones de inicio de ruta RV
    public void StartingLabRouteAnimationsEnabled()
    {
        Animator BotAnimator = BotExpand.GetComponent<Animator>();
        Animator TopAnimator = TopExpand.GetComponent<Animator>();
        Animator PlusAnimator = Btn_Plus.GetComponent<Animator>();
        Animator ExpandedAnimator = Btn_Expanded.GetComponent<Animator>();
        Animator BienvenidaAnimator = Txt_Bienvenida.GetComponent<Animator>();
        Animator InstruccionesAnimator = Instrucciones.GetComponent <Animator>();
        BotAnimator.enabled = true;
        TopAnimator.enabled = true;
        PlusAnimator.enabled = true;
        ExpandedAnimator.enabled = true;
        BienvenidaAnimator.enabled = true;
        InstruccionesAnimator.enabled = true;
    }

    public void SubtitlesDisabled()
    {
        Animator BienvenidaSalida = Txt_Bienvenida.GetComponent<Animator>();
        BienvenidaSalida.Play("BienvenidaAnimSalida");
    }
}

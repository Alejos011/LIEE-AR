using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaRV : EnableDisableRV
{
    // Start is called before the first frame update
    void Start()
    {
        //Deshabilitar el pop up de confirmación de salida
        DisableExitBgRV();
    }


    //Disparador que habilita el pop up de salida de escena
    public void ExitPopUpTrigger()
    {
        EnableExitBgRV();
    }

    //Disparador que deshabilita el pop up cuando se acciona
    public void CancelButtonTrigger()
    {
        DisableExitBgRV();
    }
}

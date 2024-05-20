using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIEELinks : MonoBehaviour
{

    public void OpenLIEEMainPage()
    {
        Application.OpenURL("https://www.inaoep.mx/~liee/");
    }

    public void OpenWorksPage()
    {
        Application.OpenURL("https://www.inaoep.mx/bolsa-de-trabajo");
    }
}

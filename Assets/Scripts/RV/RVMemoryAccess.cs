using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RVMemoryAccess : MonoBehaviour
{
    //String que almacena la posición de la pantalla de RV al seleccionar en interfaz inicial
    private string RVPantalla;

    //string donde se guarda el path donde se almacena cualquier dato
    private string filePath;

    // Start is called before the first frame update
    void Start()
    {
        //seteo de filepath
        filePath = Path.Combine(Application.persistentDataPath, "RVPantalla.txt");
    }

    //Esfera
    public void RVEsferaButtonTrigger()
    {
        RVPantalla = "1";
        File.WriteAllText(filePath, RVPantalla);
    }

    //Choque
    public void RVChoqueButtonTrigger()
    {
        RVPantalla = "2";
        File.WriteAllText(filePath, RVPantalla);
    }

    //Conmutación
    public void RVConmuButtonTrigger()
    {
        RVPantalla = "3";
        File.WriteAllText(filePath, RVPantalla);
    }

    //Foto
    public void RVFotoButtonTrigger()
    {
        RVPantalla = "4";
        File.WriteAllText(filePath, RVPantalla);
    }

    //Sobre
    public void RVSobreButtonTrigger()
    {
        RVPantalla = "5";
        File.WriteAllText(filePath, RVPantalla);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Exit : MonoBehaviour
{
    //string que guarda la posición de la pantalla anterior al seleccionar RA (cualquier banco)
    private string RAPantalla;

    //path donde se guardará la preferencia
    private string filePath;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "RAPantalla.txt");

    }

    public void RAEsferaButtonTrigger()
    {
        RAPantalla = "1";
        File.WriteAllText(filePath, RAPantalla);
    }

    public void RAChoqueButtonTrigger()
    {
        RAPantalla = "2";
        File.WriteAllText(filePath, RAPantalla);
    }

    public void RAConmuButtonTrigger()
    {
        RAPantalla = "3";
        File.WriteAllText(filePath, RAPantalla);
    }

    public void RAFotoButtonTrigger()
    {
        RAPantalla = "4";
        File.WriteAllText(filePath, RAPantalla);
    }

    public void RASobreButtonTrigger()
    {
        RAPantalla = "5";
        File.WriteAllText(filePath, RAPantalla);
    }

    public void ExitButtonTrigger()
    {
        string colector = File.ReadAllText(filePath);

        if (colector == "1")
        {
            SceneManager.LoadScene("esfera");
        }
        else if (colector == "2")
        {
            SceneManager.LoadScene("choque");
        }
        else if (colector == "3")
        {
            SceneManager.LoadScene("conmu");
        }
        else if (colector == "4")
        {
            SceneManager.LoadScene("foto");
        }
        else if (colector == "5")
        {
            SceneManager.LoadScene("sobre");
        }
    }
}


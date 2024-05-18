using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;



public class ModoOscuro : MonoBehaviour
{
    //RawImages
    public RawImage Darkselector;
    public RawImage Lightselector;

    //Textures2D para modificar los RawImage
    public Texture2D SelectorOn;
    public Texture2D SelectorOff;


    //Path del archivo donde se guardará el valor de Dark Mode (true/false)

    private string filePath;

    //La Aplicación tiene el DarkMode como falso por default
    private bool DarkModeOn;
    private string ValorDarkMode;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "DarkMode.txt");

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "false");
        }
        VerifyDarkMode();
    }

    // Update is called once per frame
    void Update()
    {
        //Verificar cambios de estado entre DarkMode (On/Off)
        SetDarkModeOnOffOnSettings();


    }

    // Función para activar Modo Oscuro
    public void ActivateDarkMode()
    {
        DarkModeOn = true;
    }
    // Función para desactivar Modo Oscuro

    public void DesactivateDarkMode()
    {
        DarkModeOn = false;
    }

    // Función para Setear el Modo Oscuro y los selectores
    private void SetDarkModeOnOffOnSettings()
    {
        if (DarkModeOn)
        {
            ValorDarkMode = "true";
            File.WriteAllText(filePath, ValorDarkMode);
            Darkselector.texture = SelectorOn;
            Lightselector.texture = SelectorOff;
        }
        else
        {
            ValorDarkMode = "false";
            File.WriteAllText(filePath, ValorDarkMode);
            Darkselector.texture = SelectorOff;
            Lightselector.texture = SelectorOn;
            
        }
    }

    public void VerifyDarkMode()
    {
        string darkModeData = File.ReadAllText(filePath);
        if (darkModeData == "true")
        {
            Darkselector.texture = SelectorOn;
            Lightselector.texture = SelectorOff;
            DarkModeOn = true;
        }

        else if (darkModeData == "false")
        {
            Darkselector.texture = SelectorOff;
            Lightselector.texture = SelectorOn;
            DarkModeOn = false;

        }
    }

}

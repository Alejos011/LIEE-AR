using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class AjustesColor : MonoBehaviour
{
    //valores predeterminados
    private string filePath;

    //Objetos tipo image a modificar
    public Image fondo;
    public Image bgmorado;
    public Image bgmorado2;
    public Image btnCambiarNombre;

    //Objetos Image del menú
    public Image bgMenu;
    public Image selector;

    //Objetos RawImage que se modificarán dependiendo el controlador para el menu
    public RawImage Ajustes;
    public RawImage Home;
    public RawImage Lab;

    //seteo de objetos Texture2D para menu
    public Texture2D AjustesLight;
    public Texture2D HomeLight;
    public Texture2D LabLight;

    public Texture2D AjustesDark;
    public Texture2D HomeDark;
    public Texture2D LabDark;

    //Objetos tipo textMeshPro a modificar
    public TextMeshProUGUI tituloAjustes;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "DarkMode.txt");
    }

    void Update()
    {
        ChangeColors();

    }

    private void ChangeColors()
    {
        string darkModeData = File.ReadAllText(filePath);

        if (darkModeData == "true")
        {
            //cambio de color general de la escena
            fondo.color = new Color32(0x41,0x41,0x41,255);
            bgmorado.color = new Color32(0x5E,0x5E,0x5E,255);
            bgmorado2.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            btnCambiarNombre.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            tituloAjustes.color = new Color32(0xFF,0xFF,0xFF,255);

            //cambio de color del menú
            bgMenu.color = new Color32(0x41, 0x41, 0x41, 255);
            selector.color = new Color32(0xFF, 0xFF, 0xFF, 255);

            //Intercambio de íconos en los RawImages
            Ajustes.texture = AjustesDark;
            Home.texture = HomeDark;
            Lab.texture = LabDark;
        }

        else if (darkModeData == "false")
        {
            //cambio de color de la escena
            fondo.color = new Color32(0xFF,0xFF,0xFF,255);
            bgmorado.color = new Color32(0x92,0x62,0x90,255);
            bgmorado2.color = new Color32(0x92,0x62,0x90,255);
            btnCambiarNombre.color = new Color32(0x92,0x62,0x90,255);
            tituloAjustes.color = new Color32(0x00,0x00,0x00,255);

            //cambio de color del menú
            bgMenu.color = new Color32(0xFF,0xFF,0xFF, 255);
            selector.color = new Color32(0x82,0x6A,0x81, 255);

            //Intercambio de íconos en los RawImages
            Ajustes.texture = AjustesLight;
            Home.texture = HomeLight;
            Lab.texture = LabLight;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class ChoqueColor : MonoBehaviour
{
    //valores predeterminados
    private string filePath;

    //Objetos Image
    public Image bgmorado;
    public Image bg2;
    //Objetos TextMesh

    //Objetos RawImage

    //Texturas



    //Objetos Image del men�
    public Image bgMenu;
    public Image selector;

    //Objetos RawImage que se modificar�n dependiendo el controlador para el menu
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

    // Start is called before the first frame update
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "DarkMode.txt");
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "false");
        }
        ChangeColors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeColors()
    {
        string darkModeData = File.ReadAllText(filePath);

        if (darkModeData == "true")
        {
            //cambio de color escena general
            bgmorado.color = new Color32(0x41, 0x41, 0x41, 255);
            bg2.color = new Color32(0x5E, 0x5E, 0x5E, 255);

            //cambio de color del men�
            bgMenu.color = new Color32(0x41, 0x41, 0x41, 255);
            selector.color = new Color32(0xFF, 0xFF, 0xFF, 255);

            //Intercambio de �conos en los RawImages
            Ajustes.texture = AjustesDark;
            Home.texture = HomeDark;
            Lab.texture = LabDark;
        }
        
        else if (darkModeData == "false")
        {
            //cambio de color del men�
            bgMenu.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            selector.color = new Color32(0x82, 0x6A, 0x81, 255);

            //Intercambio de �conos en los RawImages
            Ajustes.texture = AjustesLight;
            Home.texture = HomeLight;
            Lab.texture = LabLight;
        }


        
    }
}

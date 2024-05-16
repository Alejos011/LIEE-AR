using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class InicioColor : MonoBehaviour
{
    //valores predeterminados
    private string filePath;

    //Objetos Image Generales
    public Image fondo;
    public Image bg_GuiaAyuda;
    public Image Selector_GuiaAyuda;
    public Image SV_btn1;
    public Image SV_btn2;

    //Objetos TextMesh Generales
    public TextMeshProUGUI txt_bienvenido;
    public TextMeshProUGUI txt_nombre;
    public TextMeshProUGUI txt_GuiaAyuda;
    public TextMeshProUGUI SV_GuiaAyuda_txt1;
    public TextMeshProUGUI SV_GuiaAyuda_txt2;


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
            fondo.color = new Color32(0x41, 0x41, 0x41, 255);
            bg_GuiaAyuda.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            Selector_GuiaAyuda.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            SV_btn1.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            SV_btn2.color = new Color32(0xFF, 0xFF, 0xFF, 255);

            //textos
            txt_bienvenido.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            txt_nombre.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            txt_GuiaAyuda.color = new Color32(0x00, 0x00, 0x00, 255);
            SV_GuiaAyuda_txt1.color = new Color32(0x00, 0x00, 0x00, 255);
            SV_GuiaAyuda_txt2.color = new Color32(0x00, 0x00, 0x00, 255);


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
            //cambio de color escena general
            fondo.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            bg_GuiaAyuda.color = new Color32(0x92,0x62,0x90, 255);
            Selector_GuiaAyuda.color = new Color32(0x4A,0x27,0x48, 255);
            SV_btn1.color = new Color32(0x4A, 0x27, 0x48, 255);
            SV_btn2.color = new Color32(0x4A, 0x27, 0x48, 255);

            //textos
            txt_bienvenido.color = new Color32(0x00, 0x00, 0x00, 255);
            txt_nombre.color = new Color32(0x00, 0x00, 0x00, 255);
            txt_GuiaAyuda.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            SV_GuiaAyuda_txt1.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            SV_GuiaAyuda_txt2.color = new Color32(0xFF, 0xFF, 0xFF, 255);


            //cambio de color del menú
            bgMenu.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            selector.color = new Color32(0x82, 0x6A, 0x81, 255);

            //Intercambio de íconos en los RawImages
            Ajustes.texture = AjustesLight;
            Home.texture = HomeLight;
            Lab.texture = LabLight;
        }
    }
}

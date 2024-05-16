using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class BancosColor : MonoBehaviour
{
    //valores predeterminados
    private string filePath;

    //Objetos generales de la escena
    public Image fondo;
    public Image btn_esfera;
    public Image btn_choque;
    public Image btn_conmu;
    public Image btn_foto;
    public Image btn_sobre;

    public Image bg_esfera;
    public Image bg_choque;
    public Image bg_conmu;
    public Image bg_foto;
    public Image bg_sobre;


    //texturas
    public Texture2D nextLight;
    public Texture2D nextDark;

    //rawimages
    public RawImage esfera_next;
    public RawImage choque_next;
    public RawImage conmu_next;
    public RawImage foto_next;
    public RawImage sobre_next;

    //Textos-Titulos
    public TextMeshProUGUI txt_esfera;
    public TextMeshProUGUI txt_choque;
    public TextMeshProUGUI txt_conmu;
    public TextMeshProUGUI txt_foto;
    public TextMeshProUGUI txt_sobre;


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
            //cambio de color de la escena general
            fondo.color = new Color32(0x41, 0x41, 0x41, 255);
            btn_esfera.color = new Color32(0x5E,0x5E,0x5E,255);
            btn_choque.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            btn_conmu.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            btn_foto.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            btn_sobre.color = new Color32(0x5E, 0x5E, 0x5E, 255);

            //cambio de sprite para bot�n de continuar
            esfera_next.texture = nextDark;
            choque_next.texture = nextDark;
            conmu_next.texture = nextDark;
            foto_next.texture = nextDark;
            sobre_next.texture = nextDark;

            //cambio de color de textos
            txt_esfera.color = new Color32(0xFF,0xFF,0xFF,255);
            txt_choque.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            txt_conmu.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            txt_foto.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            txt_sobre.color = new Color32(0xFF, 0xFF, 0xFF, 255);

            //cambio de color del bg de los logos
            bg_esfera.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            bg_choque.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            bg_conmu.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            bg_foto.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            bg_sobre.color = new Color32(0xFF, 0xFF, 0xFF, 255);


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
            //cambio de color de la escena general
            fondo.color = new Color32(0x4A,0x27,0x48, 255);
            btn_esfera.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            btn_choque.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            btn_conmu.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            btn_foto.color = new Color32(0xFF, 0xFF, 0xFF, 255);
            btn_sobre.color = new Color32(0xFF, 0xFF, 0xFF, 255);

            //cambio de sprite para bot�n de continuar
            esfera_next.texture = nextLight;
            choque_next.texture = nextLight;
            conmu_next.texture = nextLight;
            foto_next.texture = nextLight;
            sobre_next.texture = nextLight;

            //cambio de color de textos
            txt_esfera.color = new Color32(0x00, 0x00, 0x00, 255);
            txt_choque.color = new Color32(0x00, 0x00, 0x00, 255);
            txt_conmu.color = new Color32(0x00, 0x00, 0x00, 255);
            txt_foto.color = new Color32(0x00, 0x00, 0x00, 255);
            txt_sobre.color = new Color32(0x00, 0x00, 0x00, 255);

            //cambio de color del bg de los logos
            bg_esfera.color = new Color32(0xF4,0xDE,0xCB, 255);
            bg_choque.color = new Color32(0xF4, 0xDE, 0xCB, 255);
            bg_conmu.color = new Color32(0xF4, 0xDE, 0xCB, 255);
            bg_foto.color = new Color32(0xF4, 0xDE, 0xCB, 255);
            bg_sobre.color = new Color32(0xF4, 0xDE, 0xCB, 255);

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
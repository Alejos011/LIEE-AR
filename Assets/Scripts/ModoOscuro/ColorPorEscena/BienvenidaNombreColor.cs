using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class BienvenidaNombreColor : MonoBehaviour
{
    //valores predeterminados
    private string filePath;

    //Objetos Image
    public Image fondo;
    public Image bgmorado;
    public Image empezar;

    public TextMeshProUGUI empezar_txt;

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
            fondo.color = new Color32(0x5E, 0x5E, 0x5E, 255);
            bgmorado.color = new Color32(0x41, 0x41, 0x41, 255);
            empezar.color = new Color32(0xFF,0xFF,0xFF,255);
            empezar_txt.color = new Color32(0x00,0x00,0x00,255);
        }

        else if (darkModeData == "false")
        {
            fondo.color = new Color32(0xD9,0xD9,0xD9,255);
            bgmorado.color = new Color32(0x4A, 0x27, 0x48, 255);
            empezar.color = new Color32(0x4A, 0x27, 0x48, 255);
            empezar_txt.color = new Color32(0xFF, 0xFF, 0xFF, 255);
        }
    }
}

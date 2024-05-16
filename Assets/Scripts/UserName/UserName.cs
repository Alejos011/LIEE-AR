using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;


public class UserName : WriteUserName
{
    public TextMeshProUGUI txt_nombre;
    void Start()
    {
        GetUserName();

    }

    //Recuperamos los datos del usuario almacenados en local
    private void GetUserName()
    {

        string filename = "UserNameData.txt";
        string filePath = Path.Combine(Application.persistentDataPath, filename);
        string Username = File.ReadAllText(filePath);
        txt_nombre.text = Username;
    }
}

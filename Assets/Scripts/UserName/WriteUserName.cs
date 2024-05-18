using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class WriteUserName : MonoBehaviour
{
    //objeto tipo image y TextMeshPro para modificar el bot�n de empezar respectivamente en pantalla del forms de bienvenida
    public Image Empezar;
    public TextMeshProUGUI txt_Empezar;

    //Objeto tipo TextMeshProUGUI para modificar comportamientos de la advertencia
    public TextMeshProUGUI Advertencia;


    //Variables privadas
    private string Name { get; set; }
    private string LastName { get; set; }
    
    //Variables de acceso publico
    public string nombreusuario { get; set; }

    void Start()
    {

    }

    void Update()
    {
        //Verificamos si los campos est�n llenos en el forms
        NameIsSetStart();
    }


    //Seteamos el nombre del usuario al presionar "Empezar" en local
    public void SetUserName()
    {
        nombreusuario = Name + " " + LastName;
        string filename = "UserNameData.txt";
        string filePath = Path.Combine(Application.persistentDataPath, filename);
        string data = nombreusuario;
        File.WriteAllText(filePath,data);
            
    }

    //M�todo que Setea el nombre del usuario dentro del forms
    public void SetName(string name)
    {
        if (name == "")
        {
            name = null;
        }
        this.Name = name;

    }

    //M�todo que Setea el Apellido del usuario dentro del forms
    public void SetLastName(string lastName)
    {
        if (lastName == "")
        {
            lastName = null;
        }
        this.LastName = lastName;
    }

    //M�todo que activa una bandera de verificaci�n de nombre existente al inicio de la app
    public void VerifyIfNameIsSet()
    {
        //NameIsSet = true;
    }

    //Funciones que habilitan o deshabilitan el bot�n de inicio
    private void DisableStartButton()
    {
        Empezar.enabled = false;
        txt_Empezar.enabled = false;
    }
    private void EnableStartButton()
    {
        Empezar.enabled = true;
        txt_Empezar.enabled = true;
    }

    //Funciones que habilitan y deshabilitan la advertencia
    private void DisableAd()
    {
        Advertencia.enabled = false;
    }

    private void EnableAd()
    {
        Advertencia.enabled = true;
    }

    //Logica para verificar si los campos est�n llenos
    void NameIsSetStart()
    {
        if (Name == null || LastName == null)
        {
            DisableStartButton();
            EnableAd();
        }
        else
        {
            EnableStartButton();
            DisableAd();
        }
            
    }

}

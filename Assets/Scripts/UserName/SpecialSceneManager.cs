using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;


public class SpecialSceneManager : MonoBehaviour
{
    string filePath;
    string location;
    string secondFilePath;
    void Start()
    {
        
        
        filePath = Path.Combine(Application.persistentDataPath, "DarkMode.txt");

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "false");
        }

        //secondFilePath = Path.Combine(Application.persistentDataPath, "UserNameData.txt");
        //File.Delete(secondFilePath);
        ValidateIfUserNameExists();
    }

    void Update()
    {
        
    }

    private void ValidateIfUserNameExists()
    {
        string filename = "UserNameData.txt";
        string filePath = Path.Combine(Application.persistentDataPath, filename);


        if (File.Exists(filePath))
        {
            StartCoroutine(HomeScene());
        }
        else
            StartCoroutine(FormScene());
    }

    private IEnumerator FormScene()
    {
        yield return new WaitForSeconds(2);
        SceneChangerForm();
    }

    private IEnumerator HomeScene()
    {
        yield return new WaitForSeconds(2);
        SceneChangerHome();
    }

    private void SceneChangerForm()
    {
        SceneManager.LoadScene("Bienvenida-empezar");
    }

    private void SceneChangerHome()
    {
        SceneManager.LoadScene("Inicio-inaoe 1");
    }

}

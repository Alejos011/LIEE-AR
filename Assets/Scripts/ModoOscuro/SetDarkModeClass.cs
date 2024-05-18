using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SetDarkModeClass : MonoBehaviour
{
    private string filePath;
    // Start is called before the first frame update
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "DarkMode.txt");

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "false");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

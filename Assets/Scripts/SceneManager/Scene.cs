using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void scene_changer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

}



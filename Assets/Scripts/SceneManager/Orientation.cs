using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour
{
    public ScreenOrientation desiredOrientation;

    void Start()
    {
        Screen.orientation = desiredOrientation;
    }

    void OnDestroy()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}

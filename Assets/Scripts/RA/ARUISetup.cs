using UnityEngine;

public class ARUISetup : MonoBehaviour
{
    public Canvas canvas;
    public GameObject marker;
    public Camera arCamera;
    public Camera uiCamera;

    void Start()
    {
        // Configuraci�n del ARCamera
        arCamera.clearFlags = CameraClearFlags.SolidColor; // o Skybox
        arCamera.cullingMask = ~(1 << LayerMask.NameToLayer("UI")); // Excluir UI
        arCamera.depth = 0;

        // Configuraci�n de la UICamera
        uiCamera.clearFlags = CameraClearFlags.Depth;
        uiCamera.cullingMask = 1 << LayerMask.NameToLayer("UI"); // Solo UI
        uiCamera.depth = 1;

        // Configuraci�n del Canvas
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = uiCamera;
        canvas.planeDistance = 1f;

        // Ajustar las posiciones de los objetos
        marker.transform.position = new Vector3(0, 0, 6);
    }
}

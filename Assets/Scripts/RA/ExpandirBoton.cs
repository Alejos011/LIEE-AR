using UnityEngine;
using UnityEngine.UI;

public class ExpandirBoton : MonoBehaviour
{

    //botones
    public Image Btn_Plus;
    public Image Btn_Salir;
    public Image Btn_Opciones;
    public Image Btn_Expanded;

    //imagenes
    public RawImage Plus;
    public RawImage Salir;
    public RawImage Opciones;


    //private Vector2 sizeExpanded = new Vector2(225, 250);
    //private Vector2 sizeOriginal;

    private bool isExpanded = false;

    private void Start()
    {
        //tama�o inicial del bot�n expandible
        //Btn_Plus.rectTransform.anchoredPosition = new Vector2(141f, Btn_Plus.rectTransform.anchoredPosition.y);
        //Btn_Plus.rectTransform.sizeDelta = new Vector2(100f, Btn_Plus.rectTransform.sizeDelta.y);
        
        //deshabilitar botones 
        Btn_Salir.enabled = false;
        Btn_Opciones.enabled = false;
        Btn_Expanded.enabled = false;

        //deshabilitar �conos
        Salir.enabled = false;
        Opciones.enabled = false;


    }

    public void AlternarExpansion()
    {


        isExpanded = !isExpanded;

        // Cambiar el tama�o del bot�n "+" y desactivar/activar im�genes y botones
        if (isExpanded)
        {
            //resize del bot�n si se activa el m�todo
            //Btn_Plus.rectTransform.anchoredPosition = new Vector2(325f, Btn_Plus.rectTransform.anchoredPosition.y);
            //Btn_Plus.rectTransform.sizeDelta = new Vector2(340f, Btn_Plus.rectTransform.sizeDelta.y);
            
            //inhabilitar �conos


            //habilitar botones
            Btn_Salir.enabled = true;
            Btn_Opciones.enabled = true;
            
            Btn_Expanded.enabled = true;
            
            //habilitar �conos
            Salir.enabled = true;
            Opciones.enabled = true;
        }
        else
        {
            //tama�o inicial del bot�n expandible
            //Btn_Plus.rectTransform.anchoredPosition = new Vector2(141f, Btn_Plus.rectTransform.anchoredPosition.y);
            //Btn_Plus.rectTransform.sizeDelta = new Vector2(100f, Btn_Plus.rectTransform.sizeDelta.y);

            //deshabilitar botones 
            Btn_Salir.enabled = false;
            Btn_Opciones.enabled = false;
            Btn_Expanded.enabled = false;

            //deshabilitar �conos
            Salir.enabled = false;
            Opciones.enabled = false;


        }
    }
}
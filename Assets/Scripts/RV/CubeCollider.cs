using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class CubeCollider : AnimSecuence
{
    //string donde se guarda el path donde se almacena el dato de RV Scene
    private string filePath;
    private string RVPantalla;

    // Diálogos para Choque
    private string[] dialogosMarcador1Choque = new string[6]
    {
        "Bienvenido al banco: Choque Térmico",
        "El choque térmico evalúa la durabilidad de una lámpara mediante ensayos de envejecimiento acelerado, midiendo su resistencia y fiabilidad.",
        "En sí, el banco cuenta con dos cámaras térmicas, tanto fría como caliente y una canastilla que desplaza la lámpara de izquierda a derecha.",
        "Durante la prueba, la lámpara se expone a temperaturas entre -10 y 50°C para evaluar su resistencia.",
        "La prueba consiste en 5 ciclos de 1 hora cada uno, con una duración total de hasta 9 horas debido a la preparación necesaria.",
        "Tras finalizar la prueba, se debe trasladar inmediatamente la lámpara al banco de conmutación."
    };

    // Diálogos para Conmutación
    private string[] dialogosMarcador1Conmu = new string[5]
    {
        "Tras la prueba de choque térmico, la lámpara se traslada al banco de conmutación para verificar su tensión, voltaje y horas de vida.",
        "Según las horas de vida de la lámpara, se divide entre 2 para determinar el número de ciclos que estará en el banco de conmutación.",
        "Es decir, si un foco tiene 10,000 horas, el total de ciclos que va tener dentro de Conmutación son 5,000.",
        "Cada ciclo conforma en prender y encender el foco cada 30 segundos, esto gracias a un temporizador y algunos cables más...",
        "¿Qué cosas no?"
    };

    // Diálogos para Sobre
    private string[] dialogosMarcador1Sobre = new string[8]
    {
        "En el banco de sobretensiones simula el efecto de un aumento repentino de voltaje sobre los valores establecidos de la lámpara.",
        "El banco genera una onda llamada ring wave para simular descargas atmosféricas hacia la lámpara.",
        "El generador de impulsos produce pulsos eléctricos, los cuales pueden ser visualizados con un osciloscopio.",
        "La punta atenuadora ajusta la señal de entrada para su visualización y medición precisa por parte del osciloscopio.",
        "Según la NOM-030-ENER-2016, las lámparas LED deben resistir 7 sobretensiones transitorias a 2.5 kV. Durante la prueba, la lámpara debe permanecer encendida.",
        "Si pasa la prueba, se espera 15 minutos para apagarla. Si no vuelve a encender, la lámpara falla la prueba.",
        "La NOM-031-ENER-2019 establece requisitos para garantizar la eficiencia, seguridad y calidad de los luminarios LED.",
        "Utilizamos estas pruebas para verificar la calidad de la electrónica de la lámpara y evaluar su confiabilidad ante fallos en la red eléctrica."
    };

    // Diálogos para Esfera
    private string[] dialogosMarcador1Esfera = new string[9]
    {
        "El banco de la esfera integradora tiene una cavidad cilíndrica con revestimiento reflectante blanco.",
        "Utilizando un espectro-radiómetro y un luxómetro, mide flujo luminoso, temperatura y rendimiento de color de la lámpara.",
        "Con un analizador de calidad de energía se obtienen datos eléctricos del comportamiento de la lámpara.",
        "El índice del rendimiento de color se percibe como la calidad del color al observar una lámpara, similar a tu percepción visual del color.",
        "El flujo luminoso es la cantidad total de luz emitida por una lampara. Cuanto mayor sea el flujo luminoso, más brillante será la fuente de luz.",
        "La temperatura de color es más sobre cómo se ve esa luz. Por ejemplo, si es una luz más cálida o fría.",
        "Es necesario realizar las mediciones para estabilizar el punto de medida de la lámpara que, requiere de una estabilización inicial de 45, 60 o 70 segundos.",
        "Las mediciones se toman cada 15 minutos para monitorear el comportamiento eléctrico.",
        "Una vez todo está estabilizado, se cierra la esfera y comienzan las pruebas."
    };

    // Diálogos para Foto
    private string[] dialogosMarcador1Foto = new string[6]
    {
        "Este banco de pruebas fotogoniómetro se utiliza para entender cómo se distribuye la luz emitida por lámparas en diferentes direcciones.",
        "Primero, verifican la intensidad de la luz con un dispositivo especial llamado luxómetro para asegurarse de que esté todo correcto.",
        "Luego, encienden la lámpara de prueba en una habitación oscura y unos sensores montados en brazos giran alrededor de la lámpara.",
        "Estos brazos giran para medir la cantidad de luz que llega desde diferentes ángulos. Es como trazar un mapa de cómo se distribuye la luz alrededor de la lámpara.",
        "Para controlar estos movimientos, usan computadoras y programas especiales que programan los movimientos de los brazos para tomar mediciones precisas.",
        "También usan una fuente de energía controlada y un dispositivo para revisar la calidad de la electricidad que alimenta la lámpara."
    };

    //AudioSource
    public AudioSource ActiveDialogue;

    //Audio Clips
    //Choque
    public AudioClip Choque_D1;
    public AudioClip Choque_D2;
    public AudioClip Choque_D3;
    public AudioClip Choque_D4;
    public AudioClip Choque_D5;
    public AudioClip Choque_D6;

    //conmu
    public AudioClip Conmu_D1;
    public AudioClip Conmu_D2;
    public AudioClip Conmu_D3;
    public AudioClip Conmu_D4;
    public AudioClip Conmu_D5;

    //sobre
    public AudioClip Sobre_D1;
    public AudioClip Sobre_D2;
    public AudioClip Sobre_D3;
    public AudioClip Sobre_D4;
    public AudioClip Sobre_D5;
    public AudioClip Sobre_D6;
    public AudioClip Sobre_D7;
    public AudioClip Sobre_D8;

    //esfera
    public AudioClip Esfera_D1;
    public AudioClip Esfera_D2;
    public AudioClip Esfera_D3;
    public AudioClip Esfera_D4;
    public AudioClip Esfera_D5;
    public AudioClip Esfera_D6;
    public AudioClip Esfera_D7;
    public AudioClip Esfera_D8;

    //Foto
    public AudioClip Foto_D1;
    public AudioClip Foto_D2;
    public AudioClip Foto_D3;
    public AudioClip Foto_D4;
    public AudioClip Foto_D5;
    public AudioClip Foto_D6;

    //Objetos tipo textmesh
    public TextMeshProUGUI txt_bienvenida;

    //Booleano que verifica si se ha entrado a un cube trigger collider
    private bool SequenceIsActive = true;

    private void OnTriggerEnter(Collider other)
    {
        //Habilitar Animaciones de ruta al chocar con el collider
        StartingLabRouteAnimationsEnabled();

        //asignación del path cuando se entra al cubo
        filePath = Path.Combine(Application.persistentDataPath, "RVPantalla.txt");

        //Recuperar el valor guardado en memoria
        RVScreenMemoryRecovery();

        if (SequenceIsActive)
        {
            //Iniciar la secuencia de audios al colisionar con el cubo
            StartCoroutine(SetActualDialoguesSequence());
            SequenceIsActive = false;
        }
        
    }


    //Recuperar valor de pantalla RV
    private void RVScreenMemoryRecovery()
    {
        RVPantalla = File.ReadAllText(filePath);
    }

    IEnumerator SetActualDialoguesSequence()
    {
        AudioClip[] selectedClips = null;
        string[] selectedDialogues = null;

        // Esfera
        if (RVPantalla == "1")
        {
            selectedClips = new AudioClip[] { Esfera_D1, Esfera_D2, Esfera_D3, Esfera_D4, Esfera_D5, Esfera_D6, Esfera_D7, Esfera_D8 };
            selectedDialogues = dialogosMarcador1Esfera;
        }
        // Choque
        else if (RVPantalla == "2")
        {
            selectedClips = new AudioClip[] { Choque_D1, Choque_D2, Choque_D3, Choque_D4, Choque_D5, Choque_D6 };
            selectedDialogues = dialogosMarcador1Choque;
        }
        // Conmutación
        else if (RVPantalla == "3")
        {
            selectedClips = new AudioClip[] { Conmu_D1, Conmu_D2, Conmu_D3, Conmu_D4, Conmu_D5 };
            selectedDialogues = dialogosMarcador1Conmu;
        }
        // Foto
        else if (RVPantalla == "4")
        {
            selectedClips = new AudioClip[] { Foto_D1, Foto_D2, Foto_D3, Foto_D4, Foto_D5, Foto_D6 };
            selectedDialogues = dialogosMarcador1Foto;
        }
        // Sobre
        else if (RVPantalla == "5")
        {
            selectedClips = new AudioClip[] { Sobre_D1, Sobre_D2, Sobre_D3, Sobre_D4, Sobre_D5, Sobre_D6, Sobre_D7, Sobre_D8 };
            selectedDialogues = dialogosMarcador1Sobre;
        }


        for (int i = 0; i < selectedClips.Length; i++)
        {
            ActiveDialogue.clip = selectedClips[i];
            txt_bienvenida.text = selectedDialogues[i];
            ActiveDialogue.Play();
            yield return new WaitForSeconds(selectedClips[i].length);

        }
    }
}

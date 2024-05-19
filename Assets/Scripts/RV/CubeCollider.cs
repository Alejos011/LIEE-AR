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

    // Di�logos para Choque
    private string[] dialogosMarcador1Choque = new string[6]
    {
        "Bienvenido al banco: Choque T�rmico",
        "El choque t�rmico eval�a la durabilidad de una l�mpara mediante ensayos de envejecimiento acelerado, midiendo su resistencia y fiabilidad.",
        "En s�, el banco cuenta con dos c�maras t�rmicas, tanto fr�a como caliente y una canastilla que desplaza la l�mpara de izquierda a derecha.",
        "Durante la prueba, la l�mpara se expone a temperaturas entre -10 y 50�C para evaluar su resistencia.",
        "La prueba consiste en 5 ciclos de 1 hora cada uno, con una duraci�n total de hasta 9 horas debido a la preparaci�n necesaria.",
        "Tras finalizar la prueba, se debe trasladar inmediatamente la l�mpara al banco de conmutaci�n."
    };

    // Di�logos para Conmutaci�n
    private string[] dialogosMarcador1Conmu = new string[5]
    {
        "Tras la prueba de choque t�rmico, la l�mpara se traslada al banco de conmutaci�n para verificar su tensi�n, voltaje y horas de vida.",
        "Seg�n las horas de vida de la l�mpara, se divide entre 2 para determinar el n�mero de ciclos que estar� en el banco de conmutaci�n.",
        "Es decir, si un foco tiene 10,000 horas, el total de ciclos que va tener dentro de Conmutaci�n son 5,000.",
        "Cada ciclo conforma en prender y encender el foco cada 30 segundos, esto gracias a un temporizador y algunos cables m�s...",
        "�Qu� cosas no?"
    };

    // Di�logos para Sobre
    private string[] dialogosMarcador1Sobre = new string[8]
    {
        "En el banco de sobretensiones simula el efecto de un aumento repentino de voltaje sobre los valores establecidos de la l�mpara.",
        "El banco genera una onda llamada ring wave para simular descargas atmosf�ricas hacia la l�mpara.",
        "El generador de impulsos produce pulsos el�ctricos, los cuales pueden ser visualizados con un osciloscopio.",
        "La punta atenuadora ajusta la se�al de entrada para su visualizaci�n y medici�n precisa por parte del osciloscopio.",
        "Seg�n la NOM-030-ENER-2016, las l�mparas LED deben resistir 7 sobretensiones transitorias a 2.5 kV. Durante la prueba, la l�mpara debe permanecer encendida.",
        "Si pasa la prueba, se espera 15 minutos para apagarla. Si no vuelve a encender, la l�mpara falla la prueba.",
        "La NOM-031-ENER-2019 establece requisitos para garantizar la eficiencia, seguridad y calidad de los luminarios LED.",
        "Utilizamos estas pruebas para verificar la calidad de la electr�nica de la l�mpara y evaluar su confiabilidad ante fallos en la red el�ctrica."
    };

    // Di�logos para Esfera
    private string[] dialogosMarcador1Esfera = new string[9]
    {
        "El banco de la esfera integradora tiene una cavidad cil�ndrica con revestimiento reflectante blanco.",
        "Utilizando un espectro-radi�metro y un lux�metro, mide flujo luminoso, temperatura y rendimiento de color de la l�mpara.",
        "Con un analizador de calidad de energ�a se obtienen datos el�ctricos del comportamiento de la l�mpara.",
        "El �ndice del rendimiento de color se percibe como la calidad del color al observar una l�mpara, similar a tu percepci�n visual del color.",
        "El flujo luminoso es la cantidad total de luz emitida por una lampara. Cuanto mayor sea el flujo luminoso, m�s brillante ser� la fuente de luz.",
        "La temperatura de color es m�s sobre c�mo se ve esa luz. Por ejemplo, si es una luz m�s c�lida o fr�a.",
        "Es necesario realizar las mediciones para estabilizar el punto de medida de la l�mpara que, requiere de una estabilizaci�n inicial de 45, 60 o 70 segundos.",
        "Las mediciones se toman cada 15 minutos para monitorear el comportamiento el�ctrico.",
        "Una vez todo est� estabilizado, se cierra la esfera y comienzan las pruebas."
    };

    // Di�logos para Foto
    private string[] dialogosMarcador1Foto = new string[6]
    {
        "Este banco de pruebas fotogoni�metro se utiliza para entender c�mo se distribuye la luz emitida por l�mparas en diferentes direcciones.",
        "Primero, verifican la intensidad de la luz con un dispositivo especial llamado lux�metro para asegurarse de que est� todo correcto.",
        "Luego, encienden la l�mpara de prueba en una habitaci�n oscura y unos sensores montados en brazos giran alrededor de la l�mpara.",
        "Estos brazos giran para medir la cantidad de luz que llega desde diferentes �ngulos. Es como trazar un mapa de c�mo se distribuye la luz alrededor de la l�mpara.",
        "Para controlar estos movimientos, usan computadoras y programas especiales que programan los movimientos de los brazos para tomar mediciones precisas.",
        "Tambi�n usan una fuente de energ�a controlada y un dispositivo para revisar la calidad de la electricidad que alimenta la l�mpara."
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

        //asignaci�n del path cuando se entra al cubo
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
        // Conmutaci�n
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

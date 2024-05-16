using System;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Secuencia : EnableDisable
{
    //Booleano bandera para activaci�n de dialogos en audio
    private bool AudioReproduciendose = false;

    //arrays donde se guardar�n los dialogos por marcador
    private string[] dialogosMarcador1Choque = new string[6];
    private string[] dialogosMarcador1Conmu = new string[5];
    private string[] dialogosMarcador1Sobre = new string[8];
    private string[] dialogosMarcador1Esfera = new string[9];
    private string[] dialogosMarcador1Foto = new string[6];

    //banderas que indican la lectura de los marcadores
    private bool marcadorLeido1Choque = false;
    private bool marcadorLeido1Conmu = false;
    private bool marcadorLeido1Sobre = false;
    private bool marcadorLeido1Esfera = false;
    private bool marcadorLeido1Foto = false;

    //modificar en caso de pruebas
    private bool banderaMarcador1Choque = false;
    private bool banderaMarcador1Conmu = false;
    private bool banderaMarcador1Sobre = false;
    private bool banderaMarcador1Esfera = false;
    private bool banderaMarcador1Foto = false;

    
    private bool banderaTerminarExplicacion = false;
    // private bool confirmarTerminar = false;

    //contador para moverse entre dialogos
    private int index = 0;
    private string colector;

    //entero que almacena la longitud del array del marcador leido
    private int longitudActual;

    void Start()
    {
        //cargar los dialogos
        SetDialogues();

        // mostrar el primer dialogo default
        Dialogos.SetText("�Bienvenido!, focaliza alguno de los marcadores dentro del banco para comenzar la explicaci�n de dicha secci�n");

        //Deshabilitar el bot�n de continuar por default al inicial la escena
        DisableContinueButton();

        //Deshabilitar el bot�n de Terminar por default al inicial la escena
        DisableFinishButton();

        //Deshabilitar Pop-up que culmina alg�n recorrido
        DisableFinishImage();

        //Deshabilitar Pop-up que verifica acci�n de empezar un recorrido
        DisableStartImage();

        //Habilitar la vista de un solo capy en escena cuando no hay marcadores leidos
        EnableDefaultCapysImage();

        StartTrigger();
    }

    void Update()
    {
        //Bloquear bot�n de regreso si el dialogo es el primero
        LockBackButtonWhenFirstDialogue();

        //Bloquear bot�n de siguiente si el dialogo es el ultimo
        LockNextButtonWhenLastDialogue();

        //Verificar marcador activado para cargar la longitud del array respectivo
        VerifyWhichMarkerIsActive();

        //Revisamos longitudes del index para habilitar o deshabilitar botones de adelante y atr�s en dialogos
        VerifyIndex();

        //Verificar estado del bot�n terminar (superior derecha)
        VerifyIfFinishIsActive();

        //Revisar la secuencia del index para mostrar capys y audios
        CapySecuence();

    }

    //Asignaci�n de di�logos por marcador (se puede modificar)
    private void SetDialogues()
    {

        //Dialogos para el primer marcador Choque
        dialogosMarcador1Choque[0] = "Bien, comenzar� explicandote el funcionamiento general del banco Choque t�rmico, pon atenci�n...";
        dialogosMarcador1Choque[1] = "El choque t�rmico eval�a la durabilidad de una l�mpara mediante ensayos de envejecimiento acelerado, midiendo su resistencia y fiabilidad.";
        dialogosMarcador1Choque[2] = "En s�, el banco cuenta con dos c�maras t�rmicas, tanto fr�a como caliente y una canastilla que desplaza la l�mpara de izquierda a derecha.";
        dialogosMarcador1Choque[3] = "Durante la prueba, la l�mpara se expone a temperaturas entre -10 y 50�C para evaluar su resistencia.";
        dialogosMarcador1Choque[4] = "La prueba consiste en 5 ciclos de 1 hora cada uno, con una duraci�n total de hasta 9 horas debido a la preparaci�n necesaria.";
        dialogosMarcador1Choque[5] = "Tras finalizar la prueba, se debe trasladar inmediatamente la l�mpara al banco de conmutaci�n.";
        
        //Dialogos para el primer marcador Conmutaci�n 
        dialogosMarcador1Conmu[0] = "Tras la prueba de choque t�rmico, la l�mpara se traslada al banco de conmutaci�n para verificar su tensi�n, voltaje y horas de vida.";
        dialogosMarcador1Conmu[1] = "Seg�n las horas de vida de la l�mpara, se divide entre 2 para determinar el n�mero de ciclos que estar� en el banco de conmutaci�n.";
        dialogosMarcador1Conmu[2] = "Es decir, si un foco tiene 10,000 horas, el total de ciclos que va tener dentro de Conmutaci�n son 5,000";
        dialogosMarcador1Conmu[3] = "Cada ciclo conforma en prender y encender el foco cada 30 segundos, esto gracias a un temporizador y algunos cables m�s...";
        dialogosMarcador1Conmu[4] = "�Qu� cosas no?";

        //Dialogos para el primer marcador Sobre
        dialogosMarcador1Sobre[0] = "En el banco de sobretensiones simula el efecto de un aumento repentino de voltaje sobre los valores establecidos de la l�mpara.";
        dialogosMarcador1Sobre[1] = "El banco genera una onda llamada ring wave para simular descargas atmosf�ricas hacia la l�mpara.";
        dialogosMarcador1Sobre[2] = "El generador de impulsos produce pulsos el�ctricos, los cuales pueden ser visualizados con un osciloscopio.";
        dialogosMarcador1Sobre[3] = "La punta atenuadora ajusta la se�al de entrada para su visualizaci�n y medici�n precisa por parte del osciloscopio.";
        dialogosMarcador1Sobre[4] = "Seg�n la NOM-030-ENER-2016, las l�mparas LED deben resistir 7 sobretensiones transitorias a 2.5 kV. Durante la prueba, la l�mpara debe permanecer encendida. ";
        dialogosMarcador1Sobre[5] = "Si pasa la prueba, se espera 15 minutos para apagarla. Si no vuelve a encender, la l�mpara falla la prueba.";
        dialogosMarcador1Sobre[6] = "La NOM-031-ENER-2019 establece requisitos para garantizar la eficiencia, seguridad y calidad de los luminarios LED.";
        dialogosMarcador1Sobre[7] = "Utilizamos estas pruebas para verificar la calidad de la electr�nica de la l�mpara y evaluar su confiabilidad ante fallos en la red el�ctrica.";

        //Dialogos para el primer marcador esfera
        dialogosMarcador1Esfera[0] = "El banco de la esfera integradora tiene una cavidad cil�ndrica con revestimiento reflectante blanco. ";
        dialogosMarcador1Esfera[1] = "Utilizando un espectro-radi�metro y un lux�metro, mide flujo luminoso, temperatura y rendimiento de color de la l�mpara.";
        dialogosMarcador1Esfera[2] = "Con un analizador de calidad de energ�a se obtienen datos el�ctricos del comportamiento de la l�mpara.";
        dialogosMarcador1Esfera[3] = "El �ndice del rendimiento de color se percibe como la calidad del color al observar una l�mpara, similar a tu percepci�n visual del color.";
        dialogosMarcador1Esfera[4] = "El flujo luminoso es la cantidad total de luz emitida por una lampara. Cuanto mayor sea el flujo luminoso, m�s brillante ser� la fuente de luz.";
        dialogosMarcador1Esfera[5] = "La temperatura de color es m�s sobre c�mo se ve esa luz. Por ejemplo, si es una luz m�s c�lida o fr�a.";
        dialogosMarcador1Esfera[6] = "Es necesario realizar las mediciones para estabilizar el punto de medida de la l�mpara que, requiere de una estabilizaci�n inicial de 45, 60 o 70 segundos.";
        dialogosMarcador1Esfera[7] = "Las mediciones se toman cada 15 minutos para monitorear el comportamiento el�ctrico.";
        dialogosMarcador1Esfera[8] = "Una vez todo est� estabilizado, se cierra la esfera y comienzan las pruebas.";

        dialogosMarcador1Foto[0] = "Este banco de pruebas fotogoni�metro se utiliza para entender c�mo se distribuye la luz emitida por l�mparas en diferentes direcciones.";
        dialogosMarcador1Foto[1] = "Primero, verifican la intensidad de la luz con un dispositivo especial llamado lux�metro para asegurarse de que est� todo correcto.";
        dialogosMarcador1Foto[2] = "Luego, encienden la l�mpara de prueba en una habitaci�n oscura y unos sensores montados en brazos giran alrededor de la l�mpara.";
        dialogosMarcador1Foto[3] = "Estos brazos giran para medir la cantidad de luz que llega desde diferentes �ngulos. Es como trazar un mapa de c�mo se distribuye la luz alrededor de la l�mpara.";
        dialogosMarcador1Foto[4] = "Para controlar estos movimientos, usan computadoras y programas especiales que programan los movimientos de los brazos para tomar mediciones precisas.";
        dialogosMarcador1Foto[5] = "Tambi�n usan una fuente de energ�a controlada y un dispositivo para revisar la calidad de la electricidad que alimenta la l�mpara.";

    }

    //L�gica de aparici�n de bot�n terminar recorrido en curso y bot�n continuar
    private void VerifyIndex()
    {

        if (index < longitudActual)
        {
            EnableFinishButton();
        }
        else
        {
            DisableFinishButton();
        }
        if (index == 0 || index < longitudActual)
        {
            DisableContinueButton();
        }
        else
        {
            EnableContinueButton();
        }

    }
    // L�gica de cambio de dialogos -> Hacia adelante (se puede optimizar)
    public void NextDialogue() 
    {

        //marcador 1 choque
        if (marcadorLeido1Choque && index <= longitudActual)
        {
            index++;
            colector = dialogosMarcador1Choque[index].ToString();
            Dialogos.SetText(colector);
            DisableContinueButton();
            AudioReproduciendose = false;
            ClipActual.Stop();
        }

        //marcador 1 conmu

        else if (marcadorLeido1Conmu && index <= longitudActual)
        {
            index++;
            colector = dialogosMarcador1Conmu[index].ToString();
            Dialogos.SetText(colector);
            DisableContinueButton();
            AudioReproduciendose = false;
            ClipActual.Stop();

        }

        //marcador 1 sobre
        else if (marcadorLeido1Sobre && index <= longitudActual)
        {
            index++;
            colector = dialogosMarcador1Sobre[index].ToString();
            Dialogos.SetText(colector);
            DisableContinueButton();
            AudioReproduciendose = false;
            ClipActual.Stop();
        }

        //marcador 1 esfera
        else if (marcadorLeido1Esfera && index <= longitudActual)
        {
            index++;
            colector = dialogosMarcador1Esfera[index].ToString();
            Dialogos.SetText(colector);
            DisableContinueButton();
            AudioReproduciendose = false;
            ClipActual.Stop();
        }

        //marcador 1 Foto
        else if (marcadorLeido1Foto && index <= longitudActual)
        {
            index++;
            colector = dialogosMarcador1Foto[index].ToString();
            Dialogos.SetText(colector);
            DisableContinueButton();
            AudioReproduciendose = false;
            ClipActual.Stop();
        }
    }

    // L�gica de cambio de dialogos -> Hacia atr�s (se puede optimizar)

    public void BackDialogue()
    {
        //marcador 1 choque
        if (marcadorLeido1Choque && index <= longitudActual)
        {
            index--;
            colector = dialogosMarcador1Choque[index].ToString();
            Dialogos.SetText(colector);
            AudioReproduciendose = false;
            ClipActual.Stop();
        }
        
        //marcador 1 conmu
        else if (marcadorLeido1Conmu && index <= longitudActual)
        {
            index--;
            colector = dialogosMarcador1Conmu[index].ToString();
            Dialogos.SetText(colector);
            AudioReproduciendose = false;
            ClipActual.Stop();
        }

        //marcador 1 sobre
        else if (marcadorLeido1Sobre && index <= longitudActual)
        {
            index--;
            colector = dialogosMarcador1Sobre[index].ToString();
            Dialogos.SetText(colector);
            AudioReproduciendose = false;
            ClipActual.Stop();
        }

        //marcador 1 esfera
        else if (marcadorLeido1Esfera && index <= longitudActual)
        {
            index--;
            colector = dialogosMarcador1Esfera[index].ToString();
            Dialogos.SetText(colector);
            AudioReproduciendose = false;
            ClipActual.Stop();

        }

        //marcador 1 foto
        else if (marcadorLeido1Foto && index <= longitudActual)
        {
            index--;
            colector = dialogosMarcador1Foto[index].ToString();
            Dialogos.SetText(colector);
            AudioReproduciendose = false;
            ClipActual.Stop();
        }
    }

    //L�gica para no permitir retroceder si el dialogo est� en la posici�n 0 
    private void LockBackButtonWhenFirstDialogue()
    {
        if (index == 0)
        {
            DisableBackButton();
        }
        else
        {
            EnableBackButton();
        }
    }

    //L�gica para no permitir adelantar si el dialogo est� en la ultima posici�n del array 
    private void LockNextButtonWhenLastDialogue()
    {
        if (index == longitudActual)
        {
            DisableNextButton();
        }
        else
        {
            EnableNextButton();
        }
    }

    //L�gica para cargar la longitud del array al leer un marcador
    private void VerifyWhichMarkerIsActive()
    {
        if (marcadorLeido1Choque)
        {
            longitudActual = dialogosMarcador1Choque.Length - 1;
        }
        else if (marcadorLeido1Conmu)
        {
            longitudActual = dialogosMarcador1Conmu.Length - 1;
        }
        else if (marcadorLeido1Sobre)
        {
            longitudActual = dialogosMarcador1Sobre.Length - 1;
        }
        else if (marcadorLeido1Esfera)
        {
            longitudActual = dialogosMarcador1Esfera.Length - 1;
        }
        else if (marcadorLeido1Foto)
        {
            longitudActual = dialogosMarcador1Foto.Length - 1;

        }

    }

    
    //Activaci�n de bandera seg�n el marcador activado

    //Lectura del marcador 1
    public void Marker1ChoqueTrigger()
    {
        EnableStartImage();
        banderaMarcador1Choque = true;
        banderaMarcador1Conmu = false;
        banderaMarcador1Sobre = false;
        banderaMarcador1Esfera = false;
    }

    //Lectura del marcador 2
    public void Marker1ConmuTrigger()
    {
        EnableStartImage();
        banderaMarcador1Conmu = true;
        banderaMarcador1Choque = false;
        banderaMarcador1Sobre = false;
        banderaMarcador1Esfera = false;
        banderaMarcador1Foto = false;
    }

    public void Marker1SobreTrigger()
    {
        EnableStartImage();
        banderaMarcador1Sobre = true;
        banderaMarcador1Conmu = false;
        banderaMarcador1Choque = false;
        banderaMarcador1Esfera = false;
        banderaMarcador1Foto = false;

    }

    public void Marker1EsferaTrigger()
    {
        EnableStartImage();
        banderaMarcador1Sobre = false;
        banderaMarcador1Conmu = false;
        banderaMarcador1Choque = false;
        banderaMarcador1Esfera = true;
        banderaMarcador1Foto = false;

    }

    public void Marker1FotoTrigger()
    {
        EnableStartImage();
        banderaMarcador1Sobre = false;
        banderaMarcador1Conmu = false;
        banderaMarcador1Choque = false;
        banderaMarcador1Esfera = false;
        banderaMarcador1Foto = true;

    }

    //al dar click en aceptar, se comprueba el marcador leido para accionar los eventos del mismo
    public void StartTrigger()
    {
        DisableStartImage();
        
        if (banderaMarcador1Choque)
        {
            marcadorLeido1Choque = true;
            Dialogos.SetText(dialogosMarcador1Choque[0].ToString());
        }
        else if (banderaMarcador1Conmu)
        {
            marcadorLeido1Conmu = true;
            Dialogos.SetText(dialogosMarcador1Conmu[0].ToString());
        }
        else if (banderaMarcador1Sobre)
        {
            marcadorLeido1Sobre = true;
            Dialogos.SetText(dialogosMarcador1Sobre[0].ToString());
        }
        else if (banderaMarcador1Esfera)
        {
            marcadorLeido1Esfera = true;
            Dialogos.SetText(dialogosMarcador1Esfera[0].ToString());
        }
        else if (banderaMarcador1Foto)
        {
            marcadorLeido1Foto = true;
            Dialogos.SetText(dialogosMarcador1Foto[0].ToString());
        }

    }

    //Al dar click en Continuar, se vuelve al estado inicial de la escena
    public void ContinueTrigger()
    {
        index = 0;
        longitudActual = 0;
        Dialogos.SetText("Focaliza nuevamente alguno de los marcadores dentro del banco para comenzar la explicaci�n de dicha secci�n");
        
        DisableContinueButton();
        DisableBackButton();
        DisableNextButton();
        EnableDefaultCapysImage();
        marcadorLeido1Choque = false;
        marcadorLeido1Conmu = false;
        marcadorLeido1Sobre = false;
        marcadorLeido1Esfera = false;
        marcadorLeido1Foto = false;
        banderaMarcador1Choque = false;
        banderaMarcador1Conmu = false;
        banderaMarcador1Sobre = false;
        banderaMarcador1Esfera = false;
        banderaMarcador1Foto = false;

        AudioReproduciendose = false;
        ClipActual.Stop();
    }

    //Al dar click en Cancelar, se vuelve al estado inicial de la escena conforme a las banderas

    public void CancelTrigger()
    {
        DisableStartImage();
        banderaMarcador1Choque = false;
        banderaMarcador1Conmu = false;
        banderaMarcador1Sobre = false;
        banderaMarcador1Esfera = false;
        banderaMarcador1Foto = false;
    }

    //Cuando se presiona el bot�n terminar (parte superior derecha) se activa el booleano bandera
    public void FinishTrigger()
    {
        banderaTerminarExplicacion = true;
        
    }

    //Funcion que verifica si el bot�n terminar ha sido activado (en el update)
    private void VerifyIfFinishIsActive()
    {
        if (banderaTerminarExplicacion)
        {
            EnableFinishImage();
            DisableBackButton();
            DisableNextButton();
            Btn_Terminar.enabled = false;
            Terminar.enabled = false;
        }
        else
        {
            DisableFinishImage();
            EnableBackButton();
            EnableNextButton();
            LockBackButtonWhenFirstDialogue();
            LockNextButtonWhenLastDialogue();

        }
    }

    //Funci�n para cerrar la c�mara AR (bot�n terminar)
    public void ConfirmFinishTrigger()
    {
        banderaTerminarExplicacion = false;
        ContinueTrigger();
        DisableFinishImage();
        EnableDefaultCapysImage();
        AudioReproduciendose = false;
        ClipActual.Stop();
    }

    //Funci�n para cerrar el popup de salida (bot�n cancelar)
    public void CancelFinishTrigger()
    {
        banderaTerminarExplicacion = false;
        EnableBackButton();
        EnableNextButton();
        DisableFinishImage();
    }

    private void CapySecuence()
    {

        //marcador 1 Choque ********************
        if (marcadorLeido1Choque && index == 0 && !AudioReproduciendose)
        {
            EnableRightCapyLunchOnly();
            VoiceManager(Choque_D1);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Choque && index == 1 && !AudioReproduciendose)
        {
            EnableRightCapyNerdOnly();
            VoiceManager(Choque_D2);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Choque && index == 2 && !AudioReproduciendose)
        {
            EnableRightCapyNerdOnly();
            VoiceManager(Choque_D3);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Choque && index == 3 && !AudioReproduciendose)
        {
            EnableLeftCapyCartoonOnly();
            VoiceManager(Choque_D4);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Choque && index == 4 && !AudioReproduciendose)
        {
            EnableRightCapyCartoonOnly();
            VoiceManager(Choque_D5);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Choque && index == 5 && !AudioReproduciendose)
        {
            EnableLeftCaparpadeoOnly();
            VoiceManager(Choque_D6);
            AudioReproduciendose = true;
        }

        //marcador 1 Conmu ********************
        if (marcadorLeido1Conmu && index == 0 && !AudioReproduciendose)
        {
            EnableRightCaparpadeoOnly();
            VoiceManager(Conmu_D1);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Conmu && index == 1 && !AudioReproduciendose)
        {
            EnableLeftCaparpadeoOnly();
            VoiceManager(Conmu_D2);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Conmu && index == 2 && !AudioReproduciendose)
        {
            EnableRightCapyLunchOnly();
            VoiceManager(Conmu_D3);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Conmu && index == 3 && !AudioReproduciendose)
        {
            EnableRightCapyLunchOnly();
            VoiceManager(Conmu_D4);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Conmu && index == 4 && !AudioReproduciendose)
        {
            EnableLeftCapyCartoonOnly();
            VoiceManager(Conmu_D5);
            AudioReproduciendose = true;
        }

        //marcador 1 Sobre *********************
        if (marcadorLeido1Sobre && index == 0 && !AudioReproduciendose)
        {
            EnableLeftCapyNerdOnly();
            VoiceManager(Sobre_D1);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Sobre && index == 1 && !AudioReproduciendose)
        {
            EnableLeftCapyNerdOnly();
            VoiceManager(Sobre_D2);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Sobre && index == 2 && !AudioReproduciendose)
        {
            EnableRightCapyCartoonOnly();
            VoiceManager(Sobre_D3);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Sobre && index == 3 && !AudioReproduciendose)
        {
            EnableRightCapyCartoonOnly();
            VoiceManager(Sobre_D4);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Sobre && index == 4 && !AudioReproduciendose)
        {
            EnableRightCapyNojaoOnly();
            VoiceManager(Sobre_D5);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Sobre && index == 5 && !AudioReproduciendose)
        {
            EnableLeftCapyNojaoOnly();
            VoiceManager(Sobre_D6);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Sobre && index == 6 && !AudioReproduciendose)
        {
            EnableRightCapyNerdOnly();
            VoiceManager(Sobre_D7);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Sobre && index == 7 && !AudioReproduciendose)
        {
            EnableRightCapyNerdOnly();
            VoiceManager(Sobre_D8);
            AudioReproduciendose = true;
        }

        //Marcador 1 esfera ******************
        
        if (marcadorLeido1Esfera && index == 0 && !AudioReproduciendose)
        {
            EnableRightCapyNojaoOnly();
            VoiceManager(Esfera_D1);
            AudioReproduciendose = true;
            

        }

        if (marcadorLeido1Esfera && index == 1 && !AudioReproduciendose)
        {
            
            EnableLeftCapyNojaoOnly();
            VoiceManager(Esfera_D2);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Esfera && index == 2 && !AudioReproduciendose)
        {
            EnableRightCapyCartoonOnly();
            VoiceManager(Esfera_D3);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Esfera && index == 3 && !AudioReproduciendose)
        {
            EnableRightCapyCartoonOnly();
            VoiceManager(Esfera_D4);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Esfera && index == 4 && !AudioReproduciendose)
        {
            EnableRightCaparpadeoOnly();
            VoiceManager(Esfera_D5);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Esfera && index == 5 && !AudioReproduciendose)
        {
            EnableLeftCaparpadeoOnly();
            VoiceManager(Esfera_D6);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Esfera && index == 6 && !AudioReproduciendose)
        {
            EnableLeftCapyCartoonOnly();
            VoiceManager(Esfera_D7);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Esfera && index == 7 && !AudioReproduciendose)
        {
            EnableLeftCapyCartoonOnly();
            VoiceManager(Esfera_D8);
            AudioReproduciendose = true;
        }

        //marcador 1 Foto *********************

        if (marcadorLeido1Foto && index == 0 && !AudioReproduciendose)
        {
            EnableLeftCapyNojaoOnly();
            VoiceManager(Foto_D1);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Foto && index == 1 && !AudioReproduciendose)
        {
            EnableRightCapyNojaoOnly();
            VoiceManager(Foto_D2);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Foto && index == 2 && !AudioReproduciendose)
        {
            EnableLeftCapyCartoonOnly();
            VoiceManager(Foto_D3);
            AudioReproduciendose = true;
        }
        if (marcadorLeido1Foto && index == 3 && !AudioReproduciendose)
        {
            EnableLeftCapyCartoonOnly();
            VoiceManager(Foto_D4);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Foto && index == 4 && !AudioReproduciendose)
        {
            EnableLeftCaparpadeoOnly();
            VoiceManager(Foto_D5);
            AudioReproduciendose = true;
        }

        if (marcadorLeido1Foto && index == 5 && !AudioReproduciendose)
        {
            EnableRightCaparpadeoOnly();
            VoiceManager(Foto_D6);
            AudioReproduciendose = true;
        }
    }

}


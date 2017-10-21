using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalQuiz : MonoBehaviour {

    static private int resultado = 0;

    static public void ZerarResultado()
    {
        resultado = 0;
    }

    static public void RespostaCorreta()
    {
        resultado++;
    }

    static public int GetResultado()
    {
        return resultado;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizTexto : MonoBehaviour {

    public Text textoAcerto, textoVaria;
    private int resultado;

	// Use this for initialization
	void Start () {
        resultado = GlobalQuiz.GetResultado();

        textoAcerto.text = string.Concat("Você Acertou ", resultado, ".");

        if (resultado <= 1)
            textoVaria.text = "É uma pena. Melhor estudar um pouco mais.";
        else if(resultado <= 3)
            textoVaria.text = "Quase lá. Estude suas dúvidas.";
        else
            textoVaria.text = "Parabéns. Você já está dominando a matéria.";

    }
}

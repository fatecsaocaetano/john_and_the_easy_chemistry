using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao : MonoBehaviour {

    public GameObject[] botoes;
    private bool respondido = false;
    public Canvas Menu;

    public void Update()
    {
        print(GlobalQuiz.GetResultado());
    }

    public void Resposta(bool certa)
    {
        if (!respondido)
        {
            for (int i = 0; i < botoes.Length; i++)
                botoes[i].SetActive(false);

            if (certa)
                GlobalQuiz.RespostaCorreta();

            Menu.enabled = true;
            respondido = true;
        }
    }
}

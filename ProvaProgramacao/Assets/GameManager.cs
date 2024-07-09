using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int pontos, teclaAtual;
    float relogio;
    KeyCode[] teclas;

    private void Start()
    {
        GerarSeta();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) == true)
        {
            ChecarTecla(DownArrow);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) == true)
        {
            ChecarTecla(UpArrow);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) == true)
        {
            ChecarTecla(RightArrow);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) == true)
        {
            ChecarTecla(LeftArrow);
        }

        ContagemRegressiva();
    }
    private void ContagemRegressiva()
    {
        relogio = relogio - Time.deltaTime;

        UIManager.instance.AtualizarTextos(pontos, relogio);

        if (relogio <= 0)
        {
            pontos = pontos - teclas.Length - teclaAtual;
        }
        GerarSetas();
    }
    private void GerarSetas()
    {
        teclaAtual = 0;

        teclas = new KeyCode[Random.RandomRange(5,15)];

        for (int i = 0; i < teclas.Length; i++)
        {
            teclas[i] = (KeyCode)Random.RandomRange(273,276);
        }
        relogio = teclas.Length / 2;
        TMP_UIStyleManager.instance.AtualizarSetas(teclas);
    }
}

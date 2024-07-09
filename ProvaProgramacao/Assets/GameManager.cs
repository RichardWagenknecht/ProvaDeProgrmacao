using System.Collections;
using System.Collections.Generic;
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

}

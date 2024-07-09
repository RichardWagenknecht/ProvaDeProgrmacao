using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Singleton
    public static UIManager instance;
    private void Awake()
    {
        instance = this;
    }

    #endregion 

    [SerializeField] private Sprite[] sprites;

    [SerializeField] private UnityEngine.UI.Image[] imagens;

    [SerializeField] private TextMeshProUGUI textoDePontuacao;

    [SerializeField] private TextMeshProUGUI textoDoRelogio;
    
    

{

    }
}
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public int VidaTotal = 5;
    public int vidaAtual;
    private int vidaTotal;

    RectTransform barravidaTotal;
    Transform canvas;
    RectTransform barraVida;

    void Satart()
    {
        vidaAtual = vidaTotal;
        verificaMorte();
        barraVida = transform.Find("BarraVida").transform.Find("VidaAtual").GetComponent<RectTransform>();
        barravidaTotal = transform.Find("BarraVidda").transform.Find("VidaTotal").GetComponent<RectTransform>();
        canvas = transform.Find("BarraVida");
    }
    private void Update()
    {
        canvas.LookAt(Camera.main.transform.position);
    }


    void atualizarHUD()
    {  
        // calcular quanto deve ser Reduzido de vida
        float reducao = (float)vidaAtual / (float)vidaTotal;
        
         //Diminuir a Barra de Vida
        //reducao = reducao * 100;
        barraVida.sizeDelta = new Vector2(reducao * 100,barraVida.sizeDelta.y);
        reducao = reducao * barravidaTotal.sizeDelta.x;
        // Realocar a posição  x da barra de vida para posição esquerda
        float posicao = (barravidaTotal.sizeDelta.x - barravidaTotal.sizeDelta.x) / 2;
        barraVida.anchoredPosition = new Vector2(posicao,barraVida.anchoredPosition.y);

    }

    public void receberDano(int valor)
    
    { 
        vidaAtual -= vidaTotal;
        verificaMorte();
        atualizarHUD();


    }
    void verificaMorte()
    {
        if (vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
    }


}

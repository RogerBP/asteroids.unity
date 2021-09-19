using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Pontuacao : MonoBehaviour
{
    public TMP_Text Score;
    public int score = 0;

    void Awake()
    {
        score = 0;
        UpdateScoreText();
        Inimigo.onDestroyInimigo += OnDestroyInimigo;
    }

    void OnDestroy()
    {
        Inimigo.onDestroyInimigo -= OnDestroyInimigo;
    }
    void OnDestroyInimigo(int p)
    {
        score += p;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        Score.text = "Score: " + score.ToString();
    }
}

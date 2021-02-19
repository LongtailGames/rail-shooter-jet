using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int score { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseScore(int scoreIncrement)
    {
        score += scoreIncrement;
        UpdateScoreGui();
    }

    private void UpdateScoreGui()
    {
        text.text = "Score: " + score.ToString();
    }
}

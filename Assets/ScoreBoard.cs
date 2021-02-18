using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public int score { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseScore(int scoreIncrement)
    {
        score += scoreIncrement;
    }

}

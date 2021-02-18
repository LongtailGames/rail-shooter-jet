using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShootableEnemy))]
public class ScoreOnShoot : MonoBehaviour
{
    public int score = 0;
    private ShootableEnemy shootableEnemy;
    // Start is called before the first frame update
    void Start()
    {
        shootableEnemy = GetComponent<ShootableEnemy>();
        shootableEnemy.onShot.AddListener( HandleOnShot);
    }

    void HandleOnShot()
    {
        ScoreBoard score = FindObjectOfType<ScoreBoard>();
        score.IncreaseScore(this.score);
        
        Debug.Log("Score is "+score.score);

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int finalScore;
    [SerializeField] private UnityEvent winAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void UpdateScore()
    {
        score++;
        if (score == finalScore) 
        {
        winAction.Invoke();
        }
    }
}

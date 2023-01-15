using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int finalScore;
    [SerializeField] private int puzzleOne;
    [SerializeField] private UnityEvent winAction;
    [SerializeField] private UnityEvent openDoor;
    [SerializeField] private UnityEvent openSafe;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void UpdateScore()
    {
        score++;
        if (score == puzzleOne)
        {
            openDoor.Invoke();
            openSafe.Invoke();
        }
        if (score == finalScore) 
        {
        winAction.Invoke();
        }
    }
}

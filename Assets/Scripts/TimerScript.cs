using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float displayTime;
    [SerializeField] private TMP_Text displayTextDoor1;
    [SerializeField] private TMP_Text displayTextDoor2;
    [SerializeField] private GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        displayTime = Mathf.Round(currentTime);
       
        if(currentTime < 0)
        {
            gameOverPanel.SetActive(true);
            displayTextDoor1.text = "Game Over!";
            displayTextDoor2.text = "Game Over!";
            Time.timeScale = 0;
        }else
        {
            displayTextDoor1.text = displayTime.ToString();
            displayTextDoor2.text = displayTime.ToString();
        }
    }


}

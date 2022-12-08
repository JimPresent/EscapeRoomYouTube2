using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float displayTime;
    [SerializeField] private TMP_Text displayText;
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
            displayText.text = "Game Over!";
            Time.timeScale = 0;
        }else
        {
            displayText.text = displayTime.ToString();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {

    }

    public void PauseGame()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }

}

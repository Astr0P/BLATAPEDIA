using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject StartScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        StartScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartTheGame();  
    }
    public void StartTheGame()
    {
        StartScreen.SetActive(false);
        Time.timeScale = 1f;
        
    }
    public void EndTheGame()
    {
        Application.Quit();
    }
}

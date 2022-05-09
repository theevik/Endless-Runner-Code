using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch : MonoBehaviour
{

    //This script controls the main menu
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void playAgain()
    {
        SceneManager.LoadScene(1);
        
    }

    public void quit()
    {
        Application.Quit();
    }
}

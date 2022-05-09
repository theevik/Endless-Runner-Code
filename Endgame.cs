using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject endScreen;

    // To end the game, I decided to just pause it whenever the player collides with a trigger, which is installed on every wall in the game.

    void Start()
    {
        endScreen.SetActive(false);
        Time.timeScale = 1;
    }

    void PauseGame()
    {
        endScreen.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }
    void OnTriggerEnter(Collider other)
    {
        PauseGame();
    }

}

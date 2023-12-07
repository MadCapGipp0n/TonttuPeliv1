using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    
    public void ContinueGame()
    {
        // Tässä voit lisätä logiikan jatkaa peliä.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("Continuing the game...");
    }

    public void Lopeta()
    {
        // Tässä voit lisätä logiikan pelin lopettamiseen.
        Application.Quit();
        Debug.Log("Quitting the game...");
        
    }
}

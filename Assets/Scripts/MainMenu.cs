using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    
    public void ContinueGame()
    {
        // T�ss� voit lis�t� logiikan jatkaa peli�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("Continuing the game...");
    }

    public void Lopeta()
    {
        // T�ss� voit lis�t� logiikan pelin lopettamiseen.
        Application.Quit();
        Debug.Log("Quitting the game...");
        
    }
}

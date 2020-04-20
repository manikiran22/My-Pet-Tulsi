using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagers : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 0f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }

    public void WinGame()
    {
        SceneManager.LoadScene(3);    
    }

    void Restart()
    {
        SceneManager.LoadScene(2);
    }

}

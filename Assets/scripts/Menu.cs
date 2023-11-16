using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class loadScene : MonoBehaviour
{
    /// <summary>
    /// The code for loading different scenes in the start menu 
    /// it looks at wich button is pressed and plays the public void thats connected to it
    /// </summary>
    public void singlePlayer()
    {
        SceneManager.LoadScene("ownVersion");
    }
    public void multiPlayer()
    {
        SceneManager.LoadScene("FinalVersion");
    }
    public void specialVariant()
    {
        SceneManager.LoadScene("ownMultiplayer");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}

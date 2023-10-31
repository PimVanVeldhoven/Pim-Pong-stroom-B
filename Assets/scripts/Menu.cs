using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class loadScene : MonoBehaviour
{
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
}

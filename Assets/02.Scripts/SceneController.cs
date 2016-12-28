using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public void PJHGameButtonClick()
    {
        SceneManager.LoadScene("PJHInGameScene");
    }
    public void KJHGameButtonClick()
    {
        SceneManager.LoadScene("KJHInGameScene");
    }
    public void KJUGameButtonClick()
    {
        SceneManager.LoadScene("KJUInGameScene");
    }
    public void KSWGameButtonClick()
    {
        SceneManager.LoadScene("KSWInGameScene");
    }
    public void SDWGameButtonClick()
    {
        SceneManager.LoadScene("SDWInGameScene");
    }
}

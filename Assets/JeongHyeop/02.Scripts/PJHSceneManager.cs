using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PJHSceneManager : MonoBehaviour {

    public void StartButtonClick()
    {
        SceneManager.LoadScene("PJHStageScene");
    }
    public void TotalMenuSceneClick()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void Stage1SceneClick()
    {
        SceneManager.LoadScene("PJHStage1Scene");
    }
    public void MainMenuSceneClick()
    {
        SceneManager.LoadScene("PJHMainMenuScene");
    }
}

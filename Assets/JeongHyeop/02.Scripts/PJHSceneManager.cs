using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PJHSceneManager : MonoBehaviour {

    public void StartButtonClick()
    {
        SceneManager.LoadScene("PJHStageScene");
    }

}

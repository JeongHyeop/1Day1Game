using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PJHInGameUI : MonoBehaviour {

    public GameObject replayButton;
    public GameObject backButton;

    bool onOffCheck = false;

	void Start () {
		
	}

    public void OptionButtonClick()
    {
        if (onOffCheck == false)
        {
            replayButton.SetActive(true);
            backButton.SetActive(true);
            onOffCheck = true;
        }
        else
        {
            replayButton.SetActive(false);
            backButton.SetActive(false);
            onOffCheck = false;
        }            
    }
}

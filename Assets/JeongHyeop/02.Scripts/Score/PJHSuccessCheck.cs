using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PJHSuccessCheck : MonoBehaviour {
    public int nSuccessCheck;
    public GameObject[] stoneImage;

	// Use this for initialization
	void Start () {
        nSuccessCheck = PlayerPrefs.GetInt("SUCCESS", nSuccessCheck);
        if (SceneManager.GetActiveScene().name == "PJHSuccessScene")
        {
            for (int i = 0; i < nSuccessCheck; i++)
            {
                stoneImage[i].SetActive(true);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

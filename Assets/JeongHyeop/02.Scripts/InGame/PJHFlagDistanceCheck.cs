using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PJHFlagDistanceCheck : MonoBehaviour {
    public GameObject flag;
    public GameObject playerStone;

    public PJHPlayButton playButton;
	public Vector3[] tempPos;
    public PJHSuccessCheck successCheck;

    float time;
	void Start () {
        tempPos[1] = playerStone.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (playButton.playButtonOnCheck == true)
        {
            time += Time.deltaTime;
      
            if (time > 23)
            {
                tempPos[0] = tempPos[1];
                time = 0;
            }          
            tempPos[1] = playerStone.transform.position;
            if (tempPos[0] == tempPos[1])
            {
                Debug.Log("멈췄다!");
                DistanceCheck();
                playButton.playButtonOnCheck = false;
            }
        }
	}
    void DistanceCheck()
    {
        //노랑
        if (playerStone.transform.position.x >= flag.transform.position.x - 1.9f && playerStone.transform.position.x <= flag.transform.position.x + 0.7f)
        {
            Debug.Log("노랑 골인");
            successCheck.nSuccessCheck = 3;
            PlayerPrefs.SetInt("SUCCESS", successCheck.nSuccessCheck);
            SceneManager.LoadScene("PJHSuccessScene");
        }
        //빨강
        else if (playerStone.transform.position.x >= flag.transform.position.x - 2.9f && playerStone.transform.position.x <= flag.transform.position.x + 1.7f)
        {
            Debug.Log("빨강 골인");
            successCheck.nSuccessCheck = 2;
            PlayerPrefs.SetInt("SUCCESS", successCheck.nSuccessCheck);
            SceneManager.LoadScene("PJHSuccessScene");
        }
        //파랑
        else if (playerStone.transform.position.x >= flag.transform.position.x - 3.9f && playerStone.transform.position.x <= flag.transform.position.x + 2.7f)
        {
            Debug.Log("파랑 골인");
            successCheck.nSuccessCheck = 1;
            PlayerPrefs.SetInt("SUCCESS", successCheck.nSuccessCheck);
            SceneManager.LoadScene("PJHSuccessScene");
        }
        else
        {
            Debug.Log("노 골");
            successCheck.nSuccessCheck = 0;
            PlayerPrefs.SetInt("SUCCESS", successCheck.nSuccessCheck);
            SceneManager.LoadScene("PJHGameOverScene");
        }
    }
}

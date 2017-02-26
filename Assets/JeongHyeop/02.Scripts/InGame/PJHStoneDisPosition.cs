using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PJHStoneDisPosition : MonoBehaviour {
    public Text playerStoneText;
    public Text supportStoneText;

    public GameObject playerStone;
    public GameObject[] supportStone;

    private int playerStoneNum = 1;
    private int supportStoneNum = 3;
    private int supportStoneCount;

    public GameObject camera;
    void Start () {
        playerStone.SetActive(false);
        supportStoneCount = supportStoneNum;
	}
		
	void Update () {

	}
    public void OnClickPlayerStone()
    {
        if (playerStoneNum > 0)
        {
            if (PlayerStoneCreate() == true)
            {
                playerStoneNum -= 1;
                playerStoneText.text = "x " + playerStoneNum.ToString();
            }
        }
    }
    public void OnClickSupportStone()
    {
        if (supportStoneNum > 0)
        {
            supportStoneNum -= 1;
            supportStoneText.text = "x " + supportStoneNum.ToString();
            SupportStoneCreate(--supportStoneCount);            
        }
    }
    bool PlayerStoneCreate()
    {        
        Vector2 cameraPos = camera.transform.position;
        if (cameraPos.x < 12.0f)
        {
            playerStone.transform.position = cameraPos;
            playerStone.SetActive(true);
            return true;
        }
        return false;
    }
    void SupportStoneCreate(int num)
    {
        supportStone[num].SetActive(true);
        Vector2 cameraPos = camera.transform.position;
        supportStone[num].transform.position = cameraPos;
    }
}

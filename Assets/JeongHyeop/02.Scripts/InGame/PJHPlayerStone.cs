using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PJHPlayerStone : MonoBehaviour {

    public Rigidbody2D playerStoneRigid;
    public PJHPlayButton playButton;

	void Start () {
        playerStoneRigid.constraints = RigidbodyConstraints2D.FreezePositionY;
	}

	void Update () {
        if (playButton.playButtonOnCheck == true)
            playerStoneRigid.constraints = RigidbodyConstraints2D.None;
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        //암벽위에다가 놓으면 다시시작
        if (coll.tag == "Block")
        {
            SceneManager.LoadScene("PJHGameOverScene");
        }
    }
}

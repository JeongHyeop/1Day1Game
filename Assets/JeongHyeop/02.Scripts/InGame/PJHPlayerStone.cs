using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJHPlayerStone : MonoBehaviour {

    public Rigidbody2D playerStoneRigid;
    public PJHPlayButton playButton;
	void Start () {
        playerStoneRigid.constraints = RigidbodyConstraints2D.FreezePositionY;
	}
	
	// Update is called once per frame
	void Update () {
        if (playButton.playButton == true)
            playerStoneRigid.constraints = RigidbodyConstraints2D.None;
	}
}

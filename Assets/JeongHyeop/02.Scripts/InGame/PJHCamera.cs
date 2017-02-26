using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJHCamera : MonoBehaviour {
    public GameObject player;
    public PJHPlayButton playButton;

    void Update()
    {
        if (playButton.playButtonOnCheck == true)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 3.0f, -10.0f);    
        }        
    }
}

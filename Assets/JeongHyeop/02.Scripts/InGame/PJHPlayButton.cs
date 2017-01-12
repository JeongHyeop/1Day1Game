using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJHPlayButton : MonoBehaviour
{
    public bool playButton = false;

    public void PlayButton()
    {
        if (playButton == false)
            playButton = true;
        else if (playButton == true)
            playButton = false;
    }
}

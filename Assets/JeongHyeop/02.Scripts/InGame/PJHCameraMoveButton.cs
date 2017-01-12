using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PJHCameraMoveButton : MonoBehaviour {

    public GameObject camera;
    public Text cameraButtonText;
    private bool cameraButton = false;
    int cameraMove;
    private Vector2 touchPos;

	void Update () {
        if (cameraButton == true)
        {            
            if (cameraMove == 0)        //Right
            {
                if (camera.transform.position.x < 51.5f)               
                    camera.transform.Translate(1.0f, 0.0f, 0.0f);
                cameraMove = -1;
            }               
            else if (cameraMove == 1)   //Left
            {
                if(camera.transform.position.x > -8.4f)                
                    camera.transform.Translate(-1.0f, 0.0f, 0.0f);
                cameraMove = -1;
            }
            else if (cameraMove == 2)   //Up
            {
                if (camera.transform.position.y < 10.0f)                 
                    camera.transform.Translate(0.0f, 1.0f, 0.0f);
                cameraMove = -1;
            }
            else if (cameraMove == 3)   //Down
            {
                if (camera.transform.position.y > -7.5f)                   
                    camera.transform.Translate(0.0f, -1.0f, 0.0f);
                cameraMove = -1;
            }
        }
	}

    public void CameraMoveButtonClick()
    {
        if (cameraButton == false)
        {
            Debug.Log("카메라 무브 활성화");
            cameraButton = true;
            cameraButtonText.color = new Color(230.0f, 0.0f, 0.0f);
            cameraButtonText.text = "ON";
        }
        else if (cameraButton == true)
        {
            Debug.Log("카메라 무브 꺼짐");
            cameraButton = false;
            cameraButtonText.text = "OFF";
            cameraButtonText.color = new Color(0.0f,0.0f,0.0f);
        }
    }

    public void CameraMoveRight()
    {
        cameraMove = 0;
    }
    public void CameraMoveLeft()
    {
        cameraMove = 1;
    }
    public void CameraMoveUp()
    {
        cameraMove = 2;
    }
    public void CameraMoveDown()
    {
        cameraMove = 3;
    }
}

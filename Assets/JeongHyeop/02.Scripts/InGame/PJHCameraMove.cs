using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJHCameraMove : MonoBehaviour {
    
    //카메라 이동 방향
    public Vector3 moveVector { get; set; }
    //카메라 이동 속도
    public float moveSpeed;
    
    public PJHCameraController cameraController;
    	
	void Start () {
        System.GC.Collect();
        moveVector = new Vector3(0, 0, 0);
	}
		
	void Update () {
        if (cameraController.cameraMoveOn == true)
        {
            HandleInput();
            if (transform.position.x > 51.5f)
                transform.position = new Vector3(51.0f, transform.position.y, transform.position.z);
            if (transform.position.x < -8.4f)
                transform.position = new Vector3(-8.0f, transform.position.y, transform.position.z);
            if (transform.position.y < -7.5f)
                transform.position = new Vector3(transform.position.x, -7.0f, transform.position.z);
            if (transform.position.y > 10.0f)
                transform.position = new Vector3(transform.position.x, 9.5f, transform.position.z);
        }
	}    
    public void HandleInput()
    {
        moveVector = PoolInput();
        Vector3 cameraPos = moveVector/4;     
        cameraPos.z = 0.0f;        
        transform.Translate(cameraPos);
    }
    public Vector3 PoolInput()
    {
        Vector3 direction = Vector3.zero;
        
        direction.x = cameraController.GetHorizontalValue();
        direction.y = cameraController.GetVerticalValue();
        
        if (direction.magnitude > 1)
            direction.Normalize();

        return direction;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PJHCameraController : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler
{
    private Image bgImage;
    private Image cameraButton;
    private Vector3 inputVector;

    public bool cameraMoveOn = false;

    void Start()
    {
        bgImage = GetComponent<Image>();
        cameraButton = transform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Debug.Log("Jostick onDrag");
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImage.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / bgImage.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);

            inputVector = new Vector3(pos.x * 2 + 1, pos.y * 2 - 1, 0);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;
            cameraButton.rectTransform.anchoredPosition = new Vector3(inputVector.x * (bgImage.rectTransform.sizeDelta.x / 3), inputVector.y * (bgImage.rectTransform.sizeDelta.y / 3));
            cameraMoveOn = true;
        }   

     }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        cameraButton.rectTransform.anchoredPosition = Vector3.zero;
    }
    public float GetHorizontalValue()
    {
        return inputVector.x;
    }
    public float GetVerticalValue()
    {
        return inputVector.y;
    }

	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            cameraButton.rectTransform.anchoredPosition = Vector3.zero;
            cameraMoveOn = false;
        }
	}
}

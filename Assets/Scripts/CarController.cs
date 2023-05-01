using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarController : MonoBehaviour ,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private PrometeoCarController _prometeoCar;
    [SerializeField]
    private bool _forward;
    private Canvas _canvas;
    private float _screenSizeWidth;
    
    private void Start()
    {
        _canvas = GetComponent<Canvas>();
        _screenSizeWidth = Screen.width;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {

        _prometeoCar._forward = true;
        _forward = true;
        _prometeoCar.DebugScript();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.position.x<_screenSizeWidth / 3)
        {
            Debug.Log("Left");
            _prometeoCar.turnLeft = true;
        }
        else
        {
            _prometeoCar.turnLeft = false;
        }

        if (eventData.position.x > _screenSizeWidth-(_screenSizeWidth / 3))
        {
            Debug.Log("Right");
            _prometeoCar.turnRight = true;
        }
        else
        {
            _prometeoCar.turnRight = false;
        }

    }
    void Update()
    {
        if (_forward)
        {
            _prometeoCar.GoForward();
        }

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        _prometeoCar._forward = false;
        _forward = false;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField]
    private Transform _carTransform;
    [Range(1, 10)]
    public float followSpeed = 5;

    private Quaternion _initialcarRotation;
    private Quaternion _initialCameraRotation;
    void Start()
    {
        _initialcarRotation = _carTransform.rotation;
        _initialCameraRotation = gameObject.transform.rotation;
    }

    private void FixedUpdate()
    {
        var rotation = Quaternion.Lerp(_carTransform.rotation, _initialcarRotation, Time.deltaTime);
        gameObject.transform.rotation = Quaternion.Lerp(rotation, _initialCameraRotation, followSpeed * Time.deltaTime);

    }
}

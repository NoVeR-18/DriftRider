using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingCar : MonoBehaviour
{
    [SerializeField]
    private PrometeoCarController _prometeoCar;
    [SerializeField]
    private Slider _maxSpeedSlider;
    [SerializeField]
    private Slider _accelerationSlider;
    [SerializeField]
    private Slider _DriftSlider;

    private void Start()
    {
        _maxSpeedSlider.value = _prometeoCar.maxSpeed;
        _accelerationSlider.value = _prometeoCar.accelerationMultiplier;
        _DriftSlider.value = _prometeoCar.handbrakeDriftMultiplier;
    }
    public void MaxSpeed()
    {
        _prometeoCar.maxSpeed = (int)_maxSpeedSlider.value;
    }
    public void Acceleration()
    {
        _prometeoCar.accelerationMultiplier = (int)_accelerationSlider.value;
    }
    public void Drift()
    {
        _prometeoCar.handbrakeDriftMultiplier = (int)_DriftSlider.value;
    }
}

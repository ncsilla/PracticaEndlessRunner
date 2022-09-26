using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Start()
    {
        Debug.Log("value");
        SoundManager.Instance.ChangeVolumen(_slider.value);
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeVolumen(val));
    }

}
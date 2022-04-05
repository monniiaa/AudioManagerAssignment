using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class AdjustSlider : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    SoundManager soundManager;

    private void Start()
    {
        soundManager = SoundManager.Instance;
    }

    private void Update()
    {
        soundManager.ChangeVolume(slider.value);
    }

}

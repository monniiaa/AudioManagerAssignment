using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleAudio : MonoBehaviour
{
    SoundManager soundManager;

    [SerializeField]
    Button button;
    [SerializeField]
    Image notplaying;


    private void Start()
    {
        soundManager = SoundManager.Instance;
        button.onClick.AddListener(To);
    }

    public void To()
    {
        if (soundManager.isPlaying)
        {
            notplaying.enabled = true;
            soundManager.PauseAudio();
        }
        else
        {
            notplaying.enabled = false;
            soundManager.PlayAudio();
        }
    }
}

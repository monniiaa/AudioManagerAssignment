using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayClip : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;

    SoundManager soundManager;
    [SerializeField]
    Button playClipButton;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = SoundManager.Instance;
        playClipButton.onClick.AddListener(PlayAudio);
    }

    void PlayAudio()
    {
        soundManager.PlayAudioClip(clip);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEventManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    public void PlayAudioEvent()
    {
        _audio.Play();
    }

    public void StopAudioEvent()
    {
        _audio.Stop();
    }
}

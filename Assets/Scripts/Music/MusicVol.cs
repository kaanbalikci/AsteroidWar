using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVol : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float SliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(SliderValue) * 20);
    }
}

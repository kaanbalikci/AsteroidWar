using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EffectVol : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float SliderValue)
    {
        mixer.SetFloat("EffectVolume", Mathf.Log10(SliderValue) * 20);
    }
}

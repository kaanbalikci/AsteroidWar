using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MasterVolume : MonoBehaviour
{
    public AudioMixer mixer;
    
    public void SetLevel(float SliderValue)
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10(SliderValue) * 20);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg_music : MonoBehaviour
{
    public static Bg_music bgmus;

    private void Awake()
    {
        if(bgmus != null && bgmus != this)
        {
            Destroy(this.gameObject);
            return;
        }

        bgmus = this;
        DontDestroyOnLoad(this);
    }
}

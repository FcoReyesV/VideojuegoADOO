using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour {
    public static SoundSystem instance;
    public AudioSource audioSourceAvioneta;
    public AudioSource audioSourceDisparo;
    //public AudioSource audioSourceFlap;
    // Use this for initialization
    private void Awake()
    {
        if (SoundSystem.instance == null)
            SoundSystem.instance = this;
        else if (SoundSystem.instance != this)
            Destroy(gameObject);
    }

    public void PlayAvionetaSound()
    {
        audioSourceAvioneta.Play();
    }
    public void PlayFireSound()
    {
        audioSourceDisparo.Play();
    }
    private void OnDestroy()
    {
        if (SoundSystem.instance == this)
            SoundSystem.instance = null;
    }
}

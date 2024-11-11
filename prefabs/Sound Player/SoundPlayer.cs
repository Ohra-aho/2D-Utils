using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public List<AudioClip> clips; //Clips to be played
    public bool ongoing; //true if sound is meant to be continious
    public float volume = 1.0f;
    public bool mute = false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        Upkeep();
    }

    //Adds AudioSource and puts the first clip to it
    public void Invoke()
    {
        this.gameObject.AddComponent<AudioSource>();
        GetComponent<AudioSource>().clip = clips[0];
        if (ongoing)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }
    }

    //Changes volume and mute according to public values
    public void Upkeep()
    {
        if (GetComponent<AudioSource>().mute != mute) GetComponent<AudioSource>().mute = mute;
        if (GetComponent<AudioSource>().volume != volume) GetComponent<AudioSource>().volume = volume;
    }

    //Changes public values
    public void UpdateStatus(bool newMute, float newVolume)
    {
        mute = newMute;
        volume = newVolume;
    }

    public void ChangeClip(int index)
    {
        GetComponent<AudioSource>().clip = clips[index];
    }

    public void PlayClip()
    {
        GetComponent<AudioSource>().Play();
    }

    public void StopClip()
    {
        GetComponent<AudioSource>().Stop();
    }

    public void PauseClip()
    {
        GetComponent<AudioSource>().Pause();
    }
}

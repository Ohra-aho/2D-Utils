using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettings : MonoBehaviour
{
    public List<SoundTarget> soundTargets = new List<SoundTarget>();
    // Start is called before the first frame update
    void Start()
    {
        soundTargets.Add(new SoundTarget("Music", false, 1));
        soundTargets.Add(new SoundTarget("Ambience", false, 1));
        soundTargets.Add(new SoundTarget("Sound Effects", false, 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MakeSettingBar(SoundTarget sountTarget)
    {

    }

    
}
public class SoundTarget
{
    public string name;
    public bool mute;
    public float volume;

    public SoundTarget(string name, bool mute, float volume)
    {
        this.name = name;
        this.mute = mute;
        this.volume = volume;
    }
}



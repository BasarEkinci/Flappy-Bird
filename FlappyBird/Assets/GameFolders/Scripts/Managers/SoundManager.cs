using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    private AudioSource[] audioSources;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(gameObject);

        audioSources = GetComponentsInChildren<AudioSource>();
    }
    
    public void PlaySound(int index)
    {
        if(!audioSources[index].isPlaying)
            audioSources[index].Play();
    }

    public void StopSound(int index)
    {
        if(audioSources[index].isPlaying)
            audioSources[index].Stop();
    }
}

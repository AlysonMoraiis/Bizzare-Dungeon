using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField]
    private AudioSource _musicSource, _effectsSource;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        _effectsSource.PlayOneShot(clip);
    }
  
    public void ChangeEffectsVolume(float value)
    {
        _effectsSource.volume = value;
    }
    public void ChangeMusicVolume(float value)
    {
        _musicSource.volume = value;
    }
}

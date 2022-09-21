using UnityEngine;

public class PlayMusicOnLevel1 : MonoBehaviour
{
    [SerializeField] private AudioSource _level1AusioSource;
    [SerializeField] private AudioClip _level1AudioClip;

    private void Update()
    {
        if(!_level1AusioSource.isPlaying)
            _level1AusioSource.PlayOneShot(_level1AudioClip);
        _level1AusioSource.volume = SetMusicVolume.musicVolumeLevel;
        
    }
}

using UnityEngine;

public class PlayMusicInMenu : MonoBehaviour
{
    [SerializeField] private AudioSource _menuAudiioSource;
    [SerializeField] private AudioClip _menuAudioClip;
    
    private void Update()
    {
        if(!_menuAudiioSource.isPlaying)
            _menuAudiioSource.PlayOneShot(_menuAudioClip);
        _menuAudiioSource.volume= SetMusicVolume.musicVolumeLevel/100;        
    }
}

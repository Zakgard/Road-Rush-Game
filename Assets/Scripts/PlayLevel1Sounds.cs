using UnityEngine;

public class PlayLevel1Sounds : MonoBehaviour
{
    [SerializeField] private AudioClip _collisionClip;
    [SerializeField] private AudioSource _collisionAudioSource;

    public static PlayLevel1Sounds Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public void PlayGameOverSound()
    {
        _collisionAudioSource.volume = SetEffectVolumeLevel.effectsVolumeLEvel;
        _collisionAudioSource.PlayOneShot(_collisionClip);        
    }
}

using UnityEngine;

public class PlayCollisionSound : MonoBehaviour
{
    [SerializeField] private AudioClip _collisionWithEnemyClip;
    [SerializeField] private AudioSource _collisionAudioSource;

    public static PlayCollisionSound Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void PlayCollisionMusic()
    {
        if (_collisionAudioSource.isPlaying == false)
        {
            _collisionAudioSource.volume = SetEffectVolumeLevel.effectsVolumeLEvel;
            _collisionAudioSource.PlayOneShot(_collisionWithEnemyClip);
        }
        
    }
}

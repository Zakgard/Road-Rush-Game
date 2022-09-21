using UnityEngine;

public class PlayRepairSound : MonoBehaviour
{
    [SerializeField] private AudioSource _repairSource;
    [SerializeField] private AudioClip _repairClip;

    public static PlayRepairSound Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void PlayRepairSoundAfterCollision()
    {
        if (_repairSource.isPlaying == false)
        {
            _repairSource.volume = SetEffectVolumeLevel.effectsVolumeLEvel;
            _repairSource.PlayOneShot(_repairClip);
        }
        
    }
}

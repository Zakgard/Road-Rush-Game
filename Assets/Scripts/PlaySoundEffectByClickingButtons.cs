using UnityEngine;

public class PlaySoundEffectByClickingButtons : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonClickAudioSource;
    [SerializeField] private AudioClip _buttonClickClip;
   
    public void OnClickButton() => _buttonClickAudioSource.PlayOneShot(_buttonClickClip);

    private void Update()
    {
        _buttonClickAudioSource.volume = SetEffectVolumeLevel.effectsVolumeLEvel/100;
    }
}

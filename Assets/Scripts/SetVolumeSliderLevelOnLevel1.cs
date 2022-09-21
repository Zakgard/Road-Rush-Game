using UnityEngine;
using UnityEngine.UI;

public class SetVolumeSliderLevelOnLevel1 : MonoBehaviour
{
    [SerializeField] private Slider _musicVolumeSlider;

    private void Awake()
    {
        _musicVolumeSlider.value = SetMusicVolume.musicVolumeLevel;
    }

    private void Update()
    {
        SetMusicVolume.musicVolumeLevel=_musicVolumeSlider.value/100;       
    }
}

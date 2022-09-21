using UnityEngine;
using UnityEngine.UI;

public class SetSFXVolumeSliderOnLevel1 : MonoBehaviour
{
    [SerializeField] private Slider _SFXSlider;

    private void Start()
    {
        _SFXSlider.value = SetEffectVolumeLevel.effectsVolumeLEvel;
    }

    private void Update()
    {
        SetEffectVolumeLevel.effectsVolumeLEvel=_SFXSlider.value;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class SetEffectVolumeLevel : MonoBehaviour
{
    [SerializeField] private Slider _effectVolumeSlider;
    public static float effectsVolumeLEvel;

    private void Update()
    {
        effectsVolumeLEvel = _effectVolumeSlider.value;        
        _effectVolumeSlider.value = effectsVolumeLEvel;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class SetMusicVolume : MonoBehaviour
{
    [SerializeField] private Slider _musicSlider;
    public static float musicVolumeLevel;
     
    private void Update()
    {
        musicVolumeLevel=_musicSlider.value;
    }
}

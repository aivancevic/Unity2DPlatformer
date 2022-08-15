using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private GameObject volumeSliderObject;
    private Slider volumeSlider;

    private void Awake()
    {
        // volumeSlider = volumeSliderObject.GetComponent<Slider>();
        // if (volumeSlider == null)
        // {
        //     Debug.LogError("Script: Options Menu\t volumeSlider is NULL");
        // }

        // volumeSlider.value = PlayerPrefs.GetFloat("MainVolume");
    }

    public void ResetHighscore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}

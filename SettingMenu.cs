using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.Rendering;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public RenderPipelineAsset[] qualityLevel;
    public TMP_Dropdown dropdown;
    void Start()
    {
        dropdown.value = QualitySettings.GetQualityLevel();
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        QualitySettings.renderPipeline = qualityLevel[qualityIndex];
    }
}

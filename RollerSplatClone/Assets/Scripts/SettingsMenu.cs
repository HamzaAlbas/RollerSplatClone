using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown dp;
    
    private void Start()
    {
        dp.value = QualitySettings.GetQualityLevel();
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}

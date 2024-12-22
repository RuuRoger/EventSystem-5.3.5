using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Private Fields
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _pointsText;
    [SerializeField] private TextMeshProUGUI _levelsText;

    #endregion

    #region Public Methods
    public void SliderLife(float currentLife)
        => _slider.value = currentLife;

    public void AddPoints(int currentPoints)
        => _pointsText.text = currentPoints.ToString();

    public void AddLevels(int currentLevels)
        => _levelsText.text = currentLevels.ToString();

    #endregion
}

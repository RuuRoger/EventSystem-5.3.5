using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //Fields
    [SerializeField] private Slider _slider;

    //Public methods
    public void SliderLife(float currentLife)
    {
        _slider.value = currentLife;
    }


}

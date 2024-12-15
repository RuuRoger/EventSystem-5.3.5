using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    //Fields
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private SoundController _sound;

    //Unity Callbacks
    private void Start()
    {
        //Event Listeners
        _playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnGetHeal += OnGetHeal;
        _playerHealth.OnDie += GetOnDie;
    }

    private void OnGetDamage()
    {
        _sound.PlayDamageSound();
        _ui.SliderLife(_playerHealth.CurrentHealth);
    }
    private void OnGetHeal()
    {
        _ui.SliderLife(_playerHealth.CurrentHealth);
    }
    private void GetOnDie()
    {
       _sound.PlayDieSound();
    }
}

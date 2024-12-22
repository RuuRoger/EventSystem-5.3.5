using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    #region Private Fields
    [SerializeField] private Points _points;
    [SerializeField] private Points _level;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private UIController _uiLevel;
    [SerializeField] private SoundController _sound;
    [SerializeField] private InputController _input;

    #endregion

    #region Unity Callbacks
    //Unity Callbacks
    private void Start()
    {
        //Events Inputs
        _input.OnKeyDamage += OnGetDamage; ;
        _input.OnKeyHeal += OnGetHeal;
        _input.OnKeyDie += GetOnDie;
        _input.OnKeyPoints += OnAddPoints;
        _input.OnKeyLevel += OnAddLevel;
    }

    #endregion

    #region Public Methods of Event Listeners
    private void OnGetDamage()
    {
        _playerHealth.GetDamage(20f);
        _sound.PlayDamageSound();
        _ui.SliderLife(_playerHealth.CurrentHealth);
    }
    private void OnGetHeal()
    {
        _playerHealth.GetHeal(20);
        _ui.SliderLife(_playerHealth.CurrentHealth);
    }
    private void GetOnDie()
    {
        _playerHealth.Die();
       _sound.PlayDieSound();
       _ui.SliderLife(_playerHealth.CurrentHealth = 0);
        Destroy(_playerHealth.gameObject);
    }
    private void OnAddPoints() 
    {
        _points.AddPoints(150);
        _ui.AddPoints(_points.CurrentPoints);
    }

    private void OnAddLevel()
    {
        _level.AddLevel(1);
       _uiLevel.AddLevels(_level.CurrentLevel);

    }

    

    #endregion
}

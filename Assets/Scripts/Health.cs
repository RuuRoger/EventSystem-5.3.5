using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    #region Public Properties
    public float CurrentHealth
    {
        get => _currentHealth;
        set
        {
            _currentHealth = value;

            if (value <= 0)
            {
                _currentHealth = 0;
                Die();
            }
            if (value > _maxHealth)
                _currentHealth = _maxHealth;
        }
    }

    #endregion

    #region Private Fields
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _currentHealth;
    [SerializeField] private bool _die;

    #endregion

    #region Events
    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;

    #endregion

    #region Unity Callbacks
    private void Start()
    {
        CurrentHealth = _maxHealth;
        _die = false;
    }

    #endregion

    #region Public Methods
    public void GetDamage(float damage)
    {
        if (!_die)
        { 
            CurrentHealth -= damage;
            Debug.Log(CurrentHealth);
            OnGetDamage?.Invoke();
        }
    }

    public void GetHeal(float life)
    {
        if (!_die) 
        {
            CurrentHealth += life;
            OnGetHeal?.Invoke();
        }
    }

    #endregion

    #region Private Methods
    public void Die()
    {
        if (!_die) 
        {
            _die = true;
            OnDie?.Invoke();
        }
    }

    #endregion



}

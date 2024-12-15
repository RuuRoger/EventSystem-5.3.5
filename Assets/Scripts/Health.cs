using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
       
    
    //Properties
    public float CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;

            if (value <= 0)
            {
                _currentHealth = 0;
                Die();
            } 
            
            if (value > _maxHealth) _currentHealth = _maxHealth;

        }
    }

    //Events
    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;

    //Fields
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _currentHealth;
    [SerializeField] private bool _die;

    //Unity Callbakcs
    private void Start()
    {
        CurrentHealth = _maxHealth;
        _die = false;
    }

    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.D))) GetDamage(20);
        if ((Input.GetKeyUp(KeyCode.H))) GetHeal(40);

    }

    //Public methods
    public void GetDamage(float damage)
    {
        CurrentHealth -= damage;
        OnGetDamage?.Invoke();
    }

    public void GetHeal(float life)
    {
        CurrentHealth += life;
        OnGetHeal?.Invoke();
    }

    //Private Methods
    private void Die()
    {
        if (!_die) 
        { 
            _die = true;
            OnDie?.Invoke();
        }
    }

 

}

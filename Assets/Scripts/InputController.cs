using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    #region Events
    public event Action OnKeyDamage;
    public event Action OnKeyHeal;
    public event Action OnKeyDie;
    public event Action OnKeyPoints;
    public event Action OnKeyLevel;

    #endregion

    #region Unity Callbacks
    private void Update()
    {
        KeyDamage();
        KeyHeal();
        KeyDie();
        KeyPoints();
        KeyLevel();
    }

    #endregion

    #region Public Methods
    public void KeyDamage()
    {
        if (Input.GetKeyUp(KeyCode.D))
            OnKeyDamage?.Invoke();
    }

    public void KeyHeal()
    {
        if (Input.GetKeyUp(KeyCode.H))
            OnKeyHeal?.Invoke();
    }

    public void KeyDie()
    {
        if (Input.GetKeyUp(KeyCode.I))
            OnKeyDie?.Invoke();
    }

    public void KeyPoints()
    { 
        if(Input.GetKeyUp(KeyCode.P))
            OnKeyPoints?.Invoke();
    }

    public void KeyLevel()
    {
        if (Input.GetKey(KeyCode.L))
            OnKeyLevel?.Invoke();
    }

    #endregion
}

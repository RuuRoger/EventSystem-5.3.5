using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int CurrentPoints
    {
        get => _currentPoints;
        set => _currentPoints = value;
    }

    public int CurrentLevel
    {
        get => _currentLevel;
        set => _currentLevel = value;
    }

    private int _currentPoints;
    private int _currentLevel;

    public event Action OnGetPoints;
    public event Action OnGetLevel;

    private void Start()
    {
        CurrentPoints = 0;
        _currentLevel = 1;
    }

    public void AddPoints(int pointsToAdd)
    {
        CurrentPoints += pointsToAdd;
        OnGetPoints?.Invoke();
    } 

    public void AddLevel(int level)
    {
        CurrentLevel += level;
        Debug.Log("Has subido de nivel.");
        OnGetLevel?.Invoke();
    }


}

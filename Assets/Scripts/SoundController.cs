using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SoundController : MonoBehaviour
{
    #region Private Fields
    [SerializeField] private AudioClip _damageSound;
    [SerializeField] private AudioClip _dieSound;
    private AudioSource _audiSource;

    #endregion

    #region Unity Callbacks
    private void Awake()
        =>_audiSource = GetComponent<AudioSource>();

    #endregion

    #region Public Methods
    public void PlayDamageSound()
    {
        _audiSource.clip = _damageSound;
        _audiSource.Play();
    }

    public void PlayDieSound()
    {
        _audiSource.clip = _dieSound;
        _audiSource.Play();
    }

    #endregion
}

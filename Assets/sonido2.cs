using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enumerador;

public class sonido2 : MonoBehaviour
{
    public AudioClip peacefulClip;
    public AudioClip combatClip;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        enumerador.OnAmbientSoundChange += ChangeAmbientSound;
    }

    void OnDisable()
    { enumerador.OnAmbientSoundChange -= ChangeAmbientSound; }
     void ChangeAmbientSound(AmbientSoundState state)
        {
            switch (state)
            {
                case AmbientSoundState.Peaceful:
                    audioSource.clip = peacefulClip;
                    break;
                case AmbientSoundState.Combat:
                    audioSource.clip = combatClip;
                    break;
            }
            audioSource.Play();
        }
    }

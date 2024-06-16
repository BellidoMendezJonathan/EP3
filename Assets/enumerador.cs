using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumerador : MonoBehaviour
{
    public enum AmbientSoundState { Peaceful, Combat }



    public delegate void AmbientSoundAction(AmbientSoundState state);
    public static event AmbientSoundAction OnAmbientSoundChange;



    public static void ChangeAmbientSound(AmbientSoundState state)
    {
        OnAmbientSoundChange?.Invoke(state);
    }

}
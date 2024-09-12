using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sound", menuName = "Scriptable Objects/Sounds", order = 1)]

public class SoundData : ScriptableObject
{
    public float Master;
    public float Music;
    public float SFX;
}

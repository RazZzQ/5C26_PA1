using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player/PlayerPoints", order = 5)]

public class PlayerPoints : ScriptableObject
{
    public int MaxPoints;
    public int CurrentPoints;
}

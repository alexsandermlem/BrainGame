using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "BrainGame/LevelConfig", order = 0)]
public class LevelConfig : ScriptableObject
{
    public List<Level> Levels;

    public Level GetLevel(int index)
    {
        return Levels[index % Levels.Count];
    }
}
using System;
using UnityEngine;

public class ConfigController : MonoBehaviour
{
    [SerializeField] private SoundConfig sound;
    [SerializeField] private LevelConfig level;
    public static SoundConfig Sound;
    public static LevelConfig Level;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        Init();
    }

    private void Init()
    {
        Sound = sound;
        Level = level;
    }
}
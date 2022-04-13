using System;
using UnityEngine;

public class ConfigController : MonoBehaviour
{
    [SerializeField] private SoundConfig sound;
    public static SoundConfig Sound;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        Init();
    }

    private void Init()
    {
        Sound = sound;
    }
}
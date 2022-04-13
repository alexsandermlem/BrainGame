using UnityEngine;

public static class Data
{
    public static bool GetBool(string key, bool defaultValue = false) => PlayerPrefs.GetInt(key, defaultValue ? 1 : 0) > 0;
    public static void SetBool(string id, bool value) => PlayerPrefs.SetInt(id, value ? 1 : 0);

    public static int GetInt(string key, int defaultValue) => PlayerPrefs.GetInt(key, defaultValue);
    public static void SetInt(string id, int value) => PlayerPrefs.SetInt(id, value);

    public static string GetString(string key, string defaultValue) => PlayerPrefs.GetString(key, defaultValue);
    public static void SetString(string id, string value) => PlayerPrefs.SetString(id, value);

    public static int IndexLevelCurrent
    {
        get => GetInt(Constant.INDEX_LEVEL_CURRENT, 0);
        set => SetInt(Constant.INDEX_LEVEL_CURRENT, value);
    }

    public static int CoinTotal
    {
        get => GetInt(Constant.COIN_TOTAL, 0);
        set => SetInt(Constant.COIN_TOTAL, value);
    }

    public static bool SoundState
    {
        get => GetBool(Constant.SOUND_STATE, true);
        set => SetBool(Constant.SOUND_STATE, value);
    }

    public static bool MusicState
    {
        get => GetBool(Constant.MUSIC_STATE, true);
        set => SetBool(Constant.MUSIC_STATE, value);
    }

    public static bool VibrateState
    {
        get => GetBool(Constant.VIBRATE_STATE, false);
        set => SetBool(Constant.VIBRATE_STATE, value);
    }
}

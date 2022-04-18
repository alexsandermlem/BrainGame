public class GameController : Singleton<GameController>
{
    public Level LevelCurrent;

    private void Awake()
    {
        PopupController.Instance.Show<GamePopup>();
    }

    private void Start()
    {
        LoadLevel();
    }

    public void LoadLevel()
    {
        if (LevelCurrent != null)
        {
            Destroy(LevelCurrent.gameObject);
        }

        var level = ConfigController.Level.GetLevel(Data.IndexLevelCurrent);
        LevelCurrent = Instantiate(level, transform);
    }

    public void NextLevel()
    {
        Data.IndexLevelCurrent++;
        LoadLevel();
    }

    public void ReplayLevel()
    {
        LoadLevel();
    }
}

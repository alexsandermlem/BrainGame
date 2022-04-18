using UnityEngine.SceneManagement;

public class GamePopup : Popup
{
    public void OnClickBackButton()
    {
        Hide();
        SceneManager.LoadScene(Constant.HOME_SCENE);
    }

    public void OnClickReplayButton()
    {
        GameController.Instance.ReplayLevel();
    }

    public void OnClickSkipButton()
    {
        GameController.Instance.NextLevel();
    }
}

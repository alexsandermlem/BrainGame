using UnityEngine.SceneManagement;

public class HomeController : Singleton<HomeController>
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene(Constant.GAME_SCENE);
    }

    public void OnClickSettingButton()
    {
        PopupController.Instance.Show<SettingPopup>();
    }
}

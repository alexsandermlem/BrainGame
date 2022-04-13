using UnityEngine.SceneManagement;

public class GameController : Singleton<GameController>
{
    public void OnClickBackButton()
    {
        SceneManager.LoadScene(Constant.HOME_SCENE);
    }
}

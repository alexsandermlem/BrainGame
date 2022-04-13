using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LoadingController : Singleton<LoadingController>
{
    public Image LoadingBar;

    private void Awake()
    {
        LoadingBar.fillAmount = 0;
    }

    private void Start()
    {
        LoadingBar.DOFillAmount(1, 2).OnComplete(() =>
        {
            SceneManager.LoadScene(Constant.HOME_SCENE);
        });
    }
}

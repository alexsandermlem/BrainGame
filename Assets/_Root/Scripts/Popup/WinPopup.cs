using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPopup : Popup
{
    public void OnClickNextButton()
    {
        Hide();
        GameController.Instance.NextLevel();
    }

    public void OnClickHomeButton()
    {
        PopupController.Instance.HideAll();
        SceneManager.LoadScene("HomeScene");
    }

    public void OnClickReplayButton()
    {
        Hide();
        GameController.Instance.ReplayLevel();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopup : Popup
{
    public void TapContinue()
    {
        Hide();
        GameController.Instance.NextLevel();
    }
}

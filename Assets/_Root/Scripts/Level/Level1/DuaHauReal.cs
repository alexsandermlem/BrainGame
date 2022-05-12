using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuaHauReal : MonoBehaviour
{
    public void OnClick()
    {
        PopupController.Instance.Show<WinPopup>();
    }
}

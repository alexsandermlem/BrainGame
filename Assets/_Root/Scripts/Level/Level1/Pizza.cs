using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public bool IsPicked;

    private void OnMouseDown()
    {
        IsPicked = true;
    }

    private void OnMouseUp()
    {
        IsPicked = false;
    }
}

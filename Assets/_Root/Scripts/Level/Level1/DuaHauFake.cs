using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuaHauFake : MonoBehaviour
{
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

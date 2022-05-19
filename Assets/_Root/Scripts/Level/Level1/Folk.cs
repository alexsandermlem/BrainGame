using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Folk : MonoBehaviour
{
    public Sprite FolkSprite;
    public Sprite FolkPickedSprite;
    public Image FolkImage;
    public bool IsPicked;
    public Collider2D Collider;

    private void OnMouseDown()
    {
        FolkImage.sprite = FolkPickedSprite;
        FolkImage.SetNativeSize();
        IsPicked = true;
        Collider.enabled = false;
    }
}

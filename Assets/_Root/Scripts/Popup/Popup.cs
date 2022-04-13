using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup), typeof(Canvas), typeof(GraphicRaycaster))]
public class Popup : MonoBehaviour
{
    public CanvasGroup CanvasGroup { get; set; }
    public Canvas Canvas { get; set; }
    public object data;

    public void Init()
    {
        CanvasGroup = GetComponent<CanvasGroup>();
        Canvas = GetComponent<Canvas>();
        AfterInstantiate();
    }

    public void Show()
    {
        BeforeShow();
        gameObject.SetActive(true);
        CanvasGroup.DOFade(1, .3f).OnComplete(() =>
        {
            CanvasGroup.interactable = true;
            AfterShown();
        });
    }

    public void Hide()
    {
        BeforeHide();
        CanvasGroup.interactable = false;
        CanvasGroup.alpha = 0;
        gameObject.SetActive(false);
        AfterHidden();
    }

    protected virtual void AfterInstantiate() { }
    protected virtual void BeforeShow() { }
    protected virtual void AfterShown() { }
    protected virtual void BeforeHide() { }
    protected virtual void AfterHidden() { }
}

using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonCustom : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Button.ButtonClickedEvent onClick;
    [SerializeField] private Button.ButtonClickedEvent onPress;

    public bool canClick = true;
    private bool isMoveEnter = false;
    private Vector3 scaleOrigin = new Vector3();

    private void Start()
    {
        scaleOrigin = transform.localScale;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canClick)
        {
            onPress?.Invoke();
            transform.DOScale(.9f, .01f).SetEase(Ease.OutQuint);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (canClick)
        {
            SoundController.Instance.PlayOnce(SoundType.ButtonClick);
            transform.localScale = scaleOrigin;
            if (isMoveEnter)
            {
                onClick?.Invoke();
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMoveEnter = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMoveEnter = false;
    }
}
using UnityEngine;
using UnityEngine.UI;

public class SpriteBtn : MonoBehaviour
{
    private Image image;
    public Sprite penguinSprite;
    public Sprite knightSprite;
    [SerializeField] private Canvas characterChoicCanvas;
    //[SerializeField] private Button[] buttons;
    private RectTransform rectTransform;    // 크기 조정을 위한 RectTransform

    private void Awake()
    {
        image = GetComponent<Image>();
        GetComponent<Button>().onClick.AddListener(ChoiceButtonActive);
        rectTransform = image.GetComponent<RectTransform>();
    }

    private void Update()
    {
        if(GameManager.Instance.GetSpriteType() == SpriteType.Penguin)
        {
            image.sprite = penguinSprite;
            rectTransform.sizeDelta = new Vector2(120, 120);
        }
        else if (GameManager.Instance.GetSpriteType() == SpriteType.Knight)
        {
            image.sprite = knightSprite;
            rectTransform.sizeDelta = new Vector2(60, 90);
        }
    }
    private void ChoiceButtonActive()
    {
        characterChoicCanvas.gameObject.SetActive(true);
        //foreach (Button button in buttons)
        //{
        //    button.interactable = false;
        //}
    }
}

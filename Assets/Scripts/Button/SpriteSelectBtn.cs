using UnityEngine;
using UnityEngine.UI;

public class SpriteSelectBtn : MonoBehaviour
{
    [SerializeField] private SpriteType spriteType;
    //[SerializeField] private Button[] mainCanvasButtons;
    private Canvas canvas;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ChoiceCharacter);
        canvas = GetComponentInParent<Canvas>();
    }

    private void ChoiceCharacter()
    {
        GameManager.Instance.SetSpriteType(spriteType);
        //foreach (Button button in mainCanvasButtons)
        //{
        //    button.interactable = true;
        //}
        canvas.gameObject.SetActive(false);
    }
}
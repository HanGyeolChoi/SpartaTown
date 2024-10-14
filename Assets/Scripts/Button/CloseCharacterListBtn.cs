using UnityEngine;
using UnityEngine.UI;

public class CloseCharacterListBtn : MonoBehaviour
{
    [SerializeField] private Canvas playerListCanvas;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(CloseCharacterList);
    }

    private void CloseCharacterList()
    {
        playerListCanvas.gameObject.SetActive(false);
    }
}
using UnityEngine;
using UnityEngine.UI;

public class CharacterListBtn : MonoBehaviour
{
    [SerializeField] private Canvas playerListCanvas;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OpenCharacterList);
    }

    private void OpenCharacterList()
    {
        if (!playerListCanvas.gameObject.activeSelf)
        {
            playerListCanvas.gameObject.SetActive(true);
        }
        else playerListCanvas.gameObject.SetActive(false);
    }
}

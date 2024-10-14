using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpriteBtn : MonoBehaviour
{
    [SerializeField] private Canvas changeSpriteCanvas;
    void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ActiveChangeSpriteCanvas);
    }

    void ActiveChangeSpriteCanvas()
    {
        changeSpriteCanvas.gameObject.SetActive(true);
    }
}

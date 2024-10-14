using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameBtn : MonoBehaviour
{
    [SerializeField] private Canvas changeNameCanvas;
    void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ActiveChangeNameCanvas);
    }

    void ActiveChangeNameCanvas()
    {
        Time.timeScale = 0f;
        changeNameCanvas.gameObject.SetActive(true);
    }
}

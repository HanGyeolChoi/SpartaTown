using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    public InputField nameInputField;
    private Canvas canvas;
    //[SerializeField] private Text warningText;
    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
        GetComponent<Button>().onClick.AddListener(GameStart);
    }
    
    private void GameStart()
    {
        if (nameInputField.text.Length < 2 || nameInputField.text.Length > 10 )
        {
            return;
        }
        GameManager.Instance.SetPlayerName(nameInputField.text);
        
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    
}

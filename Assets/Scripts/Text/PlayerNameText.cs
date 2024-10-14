using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerNameText : MonoBehaviour
{
    private Text nameText;
    void Awake()
    {
        nameText = GetComponent<Text>();
        
    }

    private void Update()
    {
        nameText.text = GameManager.Instance.GetPlayerName();
    }
}

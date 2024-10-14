using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterListText : MonoBehaviour
{
    private GameObject[] NPCList;
    private Text playerListText;
    private string tempName;
    private void Awake()
    {
        playerListText = GetComponent<Text>();
        NPCList = GameObject.FindGameObjectsWithTag("NPC");



    }
   
    private void OnEnable()
    {
        tempName = GameManager.Instance.GetPlayerName();
        playerListText.text = $"{tempName}\n";
        foreach (GameObject NPC in NPCList)
        {
            string npcName = NPC.name;
            playerListText.text += $"{npcName}\n";
        }
    }

    private void Update()
    {
        if (tempName != GameManager.Instance.GetPlayerName())
        {
            playerListText.text.Replace(tempName, GameManager.Instance.GetPlayerName());
        }
    }


}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private string playerName = "Temp";
    private SpriteType type = SpriteType.Penguin;
private void Awake()
    {
        if(Instance != null) Destroy(Instance);
        Instance = this;
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    public SpriteType GetSpriteType()
    {
        return type;
    }

    public void SetSpriteType(SpriteType spriteType)
    {
        type = spriteType;
    }
}

public enum SpriteType
{
    Penguin,
    Knight
}
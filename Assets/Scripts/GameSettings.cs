using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameSettings), menuName = nameof(GameSettings))]
public class GameSettings : ScriptableObject
{
    public int coinCount;
    public int spikeCount;

    public float lenght;
    public float width;    
}


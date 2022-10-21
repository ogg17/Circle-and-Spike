using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameSettings), menuName = nameof(GameSettings))]
public class GameSettings : ScriptableObject
{
    public int coinCount;
    public int spikeCount;
       
    [Tooltip("Playing field lenght")]
    public int lenght;
    [Tooltip("Playing field width")]
    public int width;
    [Tooltip("Playing field border")]
    public int border;
    [Tooltip("Generate object difficulty")]
    public int difficulty;
}


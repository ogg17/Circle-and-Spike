using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameWorld), menuName = nameof(GameWorld))]
public class GameWorld : ScriptableObject
{
    public GameSettings gameSettings;
    public GameObject gameScene;

    public GameObject coinPrefab;
    public GameObject spikePrefab;

    [HideInInspector] public List<GameObject> gamePool = new List<GameObject>();
}

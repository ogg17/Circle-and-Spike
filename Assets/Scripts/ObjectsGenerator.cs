using GameSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGenerator : MonoBehaviour
{
    [SerializeField] private GameWorld gameWorld;
    [SerializeField] private GameObject gameScene;

    private CoinGenerateSystem coinGenerator;
    
    // Start is called before the first frame update
    void Start()
    {
        gameWorld.gameScene = gameScene;
        coinGenerator = new CoinGenerateSystem(gameWorld, gameWorld.coinPrefab);
        coinGenerator.Init();
    }

    public void Restart(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

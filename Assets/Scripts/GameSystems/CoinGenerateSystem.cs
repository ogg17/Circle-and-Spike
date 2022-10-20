using System.Collections.Generic;
using UnityEngine;

namespace GameSystems
{
    public class CoinGenerateSystem : BaseGameSystem
    {
        public CoinGenerateSystem(GameWorld world, GameObject prefab) : base(world, prefab)
        {
        }

        public override void Init()
        {
            var settings = world.gameSettings;
            var position = Vector2.zero;
            var rotation = Quaternion.Euler(Vector3.zero);

            for (int i = 0; i <= settings.coinCount; i++)
            {
                position.x = Random.Range(0, settings.width);
                position.y = Random.Range(0, settings.lenght);
                gamePool.Add(GameObject.Instantiate(prefab, position, rotation, world.gameScene.transform));
            }
        }
    }
}
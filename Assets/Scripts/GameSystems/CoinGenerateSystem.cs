using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GameSystems
{
    public class CoinGenerateSystem : BaseGameSystem
    {
        public CoinGenerateSystem(GameWorld world) : base(world)
        {
        }

        public override void Init()
        {
            var settings = world.gameSettings;            
            var rotation = Quaternion.Euler(Vector3.zero);
            var points = GeneratePoints(settings.width, settings.lenght, settings.border, settings.coinCount + settings.spikeCount, settings.difficulty);

            for (int i = 0; i < settings.coinCount; i++)
            {
                    var coin = GameObject.Instantiate(world.coinPrefab, Vector3.zero, rotation, world.gameScene.transform);
                    world.gamePool.Add(coin);
                    var coinRect = coin.GetComponent<RectTransform>();
                    coinRect.anchoredPosition = points[i];
            }

            for (int i = 0; i < settings.spikeCount; i++)
            {
                    var spike = GameObject.Instantiate(world.spikePrefab, Vector3.zero, rotation, world.gameScene.transform);
                    world.gamePool.Add(spike);
                    var coinRect = spike.GetComponent<RectTransform>();
                    coinRect.anchoredPosition = points[i + settings.coinCount];
            }
        }

        private List<Vector2> GeneratePoints(int width, int lenght, int border, int count, int difficulty)
        {
            var points = new List<Vector2>();
            for(int i = 0; i < count; i++)
                points.Add(Vector2.zero);

            var newPoint = Vector2.zero;

            var rnd = new System.Random();
            var widthRange = (width - 1) / border;
            var lenghtRange = (lenght - 1) / border;
            var rndPosition = Enumerable.Range(1, widthRange * lenghtRange)
                .OrderBy(point => rnd.Next()).Take(count).ToList();

            for (int i = 0; i < count; i++)
            {
                Debug.Log(rndPosition[i]);
                newPoint.x = rndPosition[i] % lenghtRange + 1;
                newPoint.y = - rndPosition[i] % widthRange - 1;
                newPoint *= border;

                points[i] = newPoint;

                Debug.Log(i);
            }
       
            return points;
        }
    }
}
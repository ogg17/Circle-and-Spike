using System.Collections.Generic;
using UnityEngine;

namespace GameSystems
{
    public abstract class BaseGameSystem
    {
        protected List<GameObject> gamePool;
        protected GameObject prefab;
        protected GameWorld world;

        public BaseGameSystem(GameWorld world, GameObject prefab)
        {
            this.world = world;
            this.prefab = prefab;
            gamePool = world.gamePool;
        }

        public virtual void Init()
        {

        }

        public virtual void Loop()
        {

        }
    }
}
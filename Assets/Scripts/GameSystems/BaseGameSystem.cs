using System.Collections.Generic;
using UnityEngine;

namespace GameSystems
{
    public abstract class BaseGameSystem
    {
        protected GameWorld world;

        public BaseGameSystem(GameWorld world)
        {
            this.world = world;
        }

        public virtual void Init()
        {

        }

        public virtual void Loop()
        {

        }
    }
}
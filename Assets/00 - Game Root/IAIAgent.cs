using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vega {
    public interface IAIAgent
    {
        void ModifyHealth(int value);
        void BoostHitPoints(float t, float boost);
        
        float Health { get; }
        float HitPoints { get; }        
    }
}
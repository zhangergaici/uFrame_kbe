// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSExample {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class WavesGameComponentDestroyed {
        
        public WavesGame Group;
        
        private WavesGame _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private uFrameECSExample.MenuUI LoopGroupNode41_Item = default( uFrameECSExample.MenuUI );
        
        private UnityEngine.GameObject ActionNode42_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode42_behaviour = default( UnityEngine.MonoBehaviour );
        
        public WavesGame Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            // LoopGroupNode
            while (this.DebugInfo("0811d918-6965-44f6-aced-0d40c04986da","681dc615-c967-417e-819d-ad04ce457e6a", this) == 1) yield return null;
            var LoopGroupNode41_GroupComponents = System.ComponentSystem.RegisterComponent<uFrameECSExample.MenuUI>().Components;
            for (var LoopGroupNode41_ItemIndex = 0
            ; LoopGroupNode41_ItemIndex < LoopGroupNode41_GroupComponents.Count; LoopGroupNode41_ItemIndex++
            ) {
                LoopGroupNode41_Item = LoopGroupNode41_GroupComponents[LoopGroupNode41_ItemIndex];
                System.StartCoroutine(LoopGroupNode41_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator LoopGroupNode41_Next() {
            ActionNode42_gameObject = LoopGroupNode41_Item.gameObject;
            // ActionNode
            while (this.DebugInfo("681dc615-c967-417e-819d-ad04ce457e6a","3cb6bd13-e202-437e-8696-a59fef43f6a7", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.GameObjects.ActivateGameObject
            uFrame.ECS.Actions.GameObjects.ActivateGameObject(ActionNode42_gameObject, ActionNode42_behaviour);
            yield break;
        }
    }
}
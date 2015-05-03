// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrame.DefaultProject {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UniRx;
    
    
    public class GameServiceBase : SystemServiceMonoBehavior {
        
        /// <summary>
        /// This method is invoked whenever the kernel is loading.
        /// Since the kernel lives throughout the entire lifecycle of the game, this will only be invoked once.
        /// </summary>
        public override void Setup() {
            this.OnEvent<GameReadyEvent>().Subscribe(this.GameReadyEventHandler);
            this.OnEvent<SceneLoaderEvent>().Subscribe(this.SceneLoaderEventHandler);
        }
        
        /// <summary>
        // This method is executed when using this.Publish(new GameReadyEvent())
        /// </summary>
        public virtual void GameReadyEventHandler(GameReadyEvent data) {
            // Process the commands information.  Also, you can publish new events by using the line below.
            // this.Publish(new AnotherEvent())
        }
        
        /// <summary>
        // This method is executed when using this.Publish(new SceneLoaderEvent())
        /// </summary>
        public virtual void SceneLoaderEventHandler(SceneLoaderEvent data) {
            // Process the commands information.  Also, you can publish new events by using the line below.
            // this.Publish(new AnotherEvent())
        }
    }
}

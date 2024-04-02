using System;
using DefaultNamespace;
using UnityEngine;

namespace GameAction
{
    public enum PowerType
    {
        CanShoot = 0, // 可以射擊
        Laser = 1, // 可以發射雷射
        Star = 2 // 獲得無敵星星
    }
    
    /// <summary>
    /// 改變玩家狀態的行為
    /// </summary>
    public class PlayerAction : IGameAction
    {
        private readonly PowerType _getPower;

        public PlayerAction(PowerType type)
        {
            _getPower = type;
        }
        
        public void DoAction()
        {
            Debug.Log($"Player Get Power {_getPower}");
            
            switch (_getPower)
            {
                case PowerType.Laser:
                    PlayerManager.SetLaser();
                    break;
                case PowerType.Star:
                    PlayerManager.SetStar();
                    break;
                case PowerType.CanShoot:
                    PlayerManager.SetPlayerCanShoot();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
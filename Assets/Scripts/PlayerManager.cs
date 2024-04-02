using UnityEngine;

namespace DefaultNamespace
{
    public static class PlayerManager
    {
        public static void SetPlayerCanShoot()
        {
            Debug.Log("玩家可以射擊");
        }

        public static void SetLaser()
        {
            Debug.Log("玩家可以發射雷射");
        }

        public static void SetStar()
        {
            Debug.Log("玩家使用無敵星星");
        }
    }
}
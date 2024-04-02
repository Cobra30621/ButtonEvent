using UnityEngine;

namespace GameAction
{
    public enum ItemType
    {
        Money, // 錢
        Bullet, // 子彈
        Heart // 生命
    }
    
    /// <summary>
    /// 獲取道具的行為
    /// </summary>
    public class ItemAction : IGameAction
    {
        private readonly ItemType _itemType;
        private int _count;
        
        public ItemAction(ItemType itemType, int count)
        {
            _itemType = itemType;
            _count = count;
        }

        public void DoAction()
        {
            Debug.Log($"獲取道具 {_count} 個 {_itemType}");
        }
    }
}
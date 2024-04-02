using GameAction;

public enum ActionType
{
    Player, // 給予玩家能力
    Item, // 獲得道具
}

/// <summary>
/// 執行遊戲常見行為
/// </summary>
public class GameActionExecutor
{
    public static void ExecutorAction(ActionParameter actionParameter)
    {
        var action = GetAction(actionParameter);
        
        action.DoAction();
    }

    /// <summary>
    /// 這邊定義輸入的參數
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    private static IGameAction GetAction(ActionParameter parameter)
    {
        return parameter.ActionType switch
        {
            ActionType.Player => new PlayerAction((PowerType)parameter.IntPar1),
            ActionType.Item => new ItemAction((ItemType)parameter.IntPar1, parameter.IntPar2),
            _ => null
        };
    }
}
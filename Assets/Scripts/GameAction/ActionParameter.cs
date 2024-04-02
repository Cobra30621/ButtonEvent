using System;

/// <summary>
/// 遊戲行為的設定參數
/// </summary>
[Serializable]
public class ActionParameter
{
    public ActionType ActionType;
    public int IntPar1;
    public int IntPar2;

    public float FloatPar1;
    public float FloatPar2;
}
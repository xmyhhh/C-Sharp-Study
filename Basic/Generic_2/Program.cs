public abstract class StateConditionSO
{
    protected abstract Condition CreateCondition();
}


public abstract class StateConditionSO<T> : StateConditionSO where T : Condition, new()
{
    protected override Condition CreateCondition() => new T();
}

public class Condition
{
    private bool isCached = false;
    private bool cachedStatement = default;
    internal StateConditionSO originSO;
}


public class Program
{
    public static void Main()
    {

    }
}

public class ControllerBase
{

}
public class ControllerPlaye : ControllerBase
{

}

public class CharacterDataBase
{
    public string weapon;
}

public class CharacterDataPlayer : CharacterDataBase
{

}
public class State
{
    public ControllerBase controllerBase;
    public State(ControllerBase _controllerBase)
    {
        controllerBase = _controllerBase;
    }

}
public class Attack : State
{
    public Attack(ControllerBase _controllerBase) : base(_controllerBase)
    {

    }

    public void attack()
    {

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public class CharacterTurn: State
    {

    public State attackChooseState;

    public override void Enter()
    {
        base.Enter();
        attackChooseState.Enter();
    }
}

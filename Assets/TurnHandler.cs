using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.RPG_framework.Character;
public delegate void OnTurnExit();


public abstract class TurnHandler:MonoBehaviour
    {

   



    

    //this event needs to be called on Turn end
    public event OnTurnExit OnturnExitEvent;



    public abstract void OnTurnUpdate();
    public virtual void OnTurnStart(OnTurnExit TurnHandlerExitFunc)
    {
        OnturnExitEvent += TurnHandlerExitFunc;
    }
    public virtual void OnTurnExit()
    {
        OnturnExitEvent();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.RPG_framework;

public class BattleManager : MonoBehaviour
{

    [SerializeField]
    List<TurnHandler> turns = new List<TurnHandler>();
    TurnHandler currentturn;

    OnTurnExit func;
    private void Start()
    {
        func = OnExit;
        currentturn = turns[0];

        currentturn.OnTurnStart(func);
    }

    private void Update()
    {
        currentturn.OnTurnUpdate();
        
    }

    void OnExit()
    {
        Debug.Log("Next Turn");
    }
}

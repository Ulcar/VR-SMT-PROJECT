using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Assets.RPG_framework.Character;
using Assets.RPG_framework.Skills;

// This class uses Unity UI Events To do attacks, only handles one character's turn.
  public  class CharacterTurnHandler:TurnHandler
    {
    public Character character;
    Skill chosenSkill;
    
    [SerializeField]
    List<Character> enemies = new List<Character>();

    [SerializeField]
    private GameObject TargetPrefab;

    [SerializeField]
    private GameObject PlayerUI;


    public override void OnTurnStart(OnTurnExit TurnHandlerExitFunc)
    {
        base.OnTurnStart(TurnHandlerExitFunc);
        PlayerUI.SetActive(true);
    }

    public override void OnTurnUpdate()
    {

    }




  public  void OnAttackButtonClicked()
    {
        chosenSkill = character.DefaultAttack; 
        foreach (Character enemy in enemies)
        {
            GameObject tmp = Instantiate(TargetPrefab);
            tmp.GetComponentInChildren<Text>().text = enemy.characterName;
            tmp.GetComponent<CharacterUIData>().OnClick += OnTargetButtonClicked;
            tmp.GetComponent<CharacterUIData>().Parent = enemy.gameObject;

        }
    }

  public  void OnTargetButtonClicked(GameObject obj)
    {
        obj.GetComponent<Character>().HandleActionHit(character.DefaultAttack);
        foreach (CharacterUIData target in obj.GetComponentsInChildren<CharacterUIData>())
        {
            Destroy(target.gameObject);
        }
        OnTurnExit();
    }

    public override void OnTurnExit()
    {
        base.OnTurnExit();
    }
}

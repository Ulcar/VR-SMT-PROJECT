using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.RPG_framework.Skills;

namespace Assets.RPG_framework.Character
{
   public class Character:MonoBehaviour
    {
        [SerializeField]
        int currentHP;
        [SerializeField]
        int currentMP;
        public string characterName { get; private set; }

        [SerializeField]
        public Skill DefaultAttack;

        public CharacterStats characterStats;



        public void HandleActionHit(Skill skill)
        {
            Debug.Log(characterName +  "Hit by" + skill);
        }

    }
}

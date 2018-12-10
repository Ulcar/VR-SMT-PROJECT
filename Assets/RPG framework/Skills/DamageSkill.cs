using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.RPG_framework.Skills
{
    [CreateAssetMenu]
    class DamageSkill:Skill
    {
       public int damage;
       public Type type;
        public int MPCost;


        void TriggerSkill(Character.Character target) {

        }

        void Triggerskill(List<Character.Character> targets) {

        }
    }
}

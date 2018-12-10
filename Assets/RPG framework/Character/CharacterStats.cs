using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.RPG_framework.Skills;
using UnityEngine;

namespace Assets.RPG_framework.Character
{
    [CreateAssetMenu]
   public class CharacterStats:ScriptableObject
    {
        public string CharacterName;
        public List<Skill> skills;

      public  int exp;
       public int level;

      public  int HP;
      public  int strength;
       public int dex;
       public int mag;
       public int luck;



    }
}

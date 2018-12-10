using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.RPG_framework.Skills
{
    public abstract class Skill : ScriptableObject
    {

        public string SkillName;
        public string description;
        public Animation animation;

        bool allied;

        float damageMultiplier;
        Type type;

    }


    public enum Type
    {
        fire, ice
    };
}

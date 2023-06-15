using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NovaSkillTree
{
    [CreateAssetMenu(menuName = "SkillCreate", fileName = "newSkill")]
    public abstract class SkillObject : ScriptableObject
    {
        public string Skill_Name;
        public int pointsToUnlock;

        public abstract void Use();
    }
}

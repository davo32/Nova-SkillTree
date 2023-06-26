using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NovaSkillTree
{
    [CreateAssetMenu(menuName = "SkillCreate", fileName = "newSkill")]
    public class SkillObject : ScriptableObject
    {
        public string Skill_Name;
        public Sprite Icon;
        public SkillType skillType;
        public int UpgradesAllowed;
        public int pointsToUnlock;

    }
}

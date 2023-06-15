using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NovaSkillTree
{
    public class SkillNode : MonoBehaviour

    {
        public SkillNode(SkillObject _Skill, bool unlocked, int ID, SkillNode _prevLeft = null, SkillNode _prevRight = null, SkillNode _left = null, SkillNode _right = null)
        {
            //Constructor
            Skill = _Skill;
            isUnlocked = unlocked;
            Skill_ID = ID;

            prevleft = _prevLeft;
            prevright = _prevRight;
            left = _left;
            right = _right;

        }
        ~SkillNode()
        {
            //Deconstructor
            Skill = null;

            prevleft = null;
            prevright = null;

            left = null;
            right = null;
        }


        //DATA
        public SkillObject Skill;
        public bool isUnlocked;
        public int Skill_ID;

        //TREE DATA
        public SkillNode prevleft;
        public SkillNode prevright;

        public SkillNode left;
        public SkillNode right;
    }
}

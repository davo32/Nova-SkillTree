using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;
using UnityEngine.UI;


namespace NovaSkillTree
{
    public class SkillUI : MonoBehaviour
    {
        [Header("Skill UI")]
        [SerializeField] private Image[] SkillBorder;
        [SerializeField] private SkillType skillType = SkillType.NONE;
        private Color BorderColor;


        [Header("Upgrade UI")]
        [Range(0,3)]
        [SerializeField]
        private int upgradeCount;
      
        [SerializeField]
        private List<GameObject> Upgrades = new List<GameObject>();

        //*******************************************************************************

        public void SetUpgradeCount(int UpgradeCount)
        {
            //Incase they arent already Disabled we do this
            DisableUpgradeUI();

            for (int i = 0; i < UpgradeCount; i++)
            {
                Upgrades[i].SetActive(true);
            }
        }

       void DisableUpgradeUI()
       {
            for (int i = 0; i < Upgrades.Count; i++)
            {
                Upgrades[i].SetActive(false);
            }
       }

        public void SetBorderColor(SkillType type)
        {
            switch(type)
            {
                case SkillType.NONE:
                {
                   BorderColor = Color.gray; break;
                }
                case SkillType.DAMAGE: 
                {
                    BorderColor = Color.red;break;
                }
                case SkillType.DEFENCE:
                {
                    BorderColor = Color.blue;break;
                }
                case SkillType.VITALITY:
                {
                   BorderColor = Color.green;break;
                }
                case SkillType.MAGIC:
                {
                    BorderColor = Color.cyan;break;
                }
            }
            for (int i = 0; i < SkillBorder.Length; i++)
            {
                SkillBorder[i].color = BorderColor;
            }
        }

        //*******************************************************************************


        void Update()
        {
           SetUpgradeCount(upgradeCount);
           SetBorderColor(skillType);
        }

        
    }
}

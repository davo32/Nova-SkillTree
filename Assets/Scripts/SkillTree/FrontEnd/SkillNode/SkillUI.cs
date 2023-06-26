using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace NovaSkillTree
{
    public class SkillUI : MonoBehaviour
    {
        [Header("Skill UI")]
        public SkillObject skill;
        public Image[] SkillBorder;
        [SerializeField] private Button button;
        [SerializeField] private Image skillImage;

        public bool isUnlocked;
        public bool isCategory;

        [SerializeField]
        private SkillType skillType;
        public SkillType SkillType
        { 
            get 
            { 
                return skillType;
            }
            set 
            {
                skillType = value;
                SetBorderColor(skillType);
            }
        }

        private Color BorderColor;

        [Header("Upgrade UI")]
        [Range(0, 3)]
        [SerializeField]
        private int upgradeCount;
        public int UpgradeCount
        {
            get 
            { 
                return upgradeCount;
            }
            set 
            { 
                upgradeCount = value;
                SetUpgradeCount(upgradeCount);
            }
        }
      
        [SerializeField]
        private List<GameObject> Upgrades = new List<GameObject>();


        //*******************************************************************************

        private void Start()
        {
            SetBorderColor(skillType);
        }


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

        public void DisableUpgradeUI()
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

        public void CheckLockedState()
        {
          button.interactable = isUnlocked;

            if (isUnlocked && !isCategory)
            {
                gameObject.GetComponent<EventTrigger>().enabled = false;
            }
            else
            {
                GetComponent<ShowCategoryData>().Count = skill.pointsToUnlock;
            }

        }

        //*******************************************************************************

        void Update()
        {
            if (skill)
            {
                this.UpgradeCount = skill.UpgradesAllowed;
                this.SkillType = skill.skillType;
                this.skillImage.sprite = skill.Icon;
                CheckLockedState();
            }
        }

        
    }
}

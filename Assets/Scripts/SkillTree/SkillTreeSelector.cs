using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NovaSkillTree
{

    public class SkillTreeSelector : MonoBehaviour
    {
        public GameObject MainScreen;
        public GameObject[] SkillTreeScreens;


        [SerializeField] private GameObject scrollView;
        [SerializeField] private Button BackBtn;

        public void ChooseSkillType(int i)
        {
            MainScreen.SetActive(false);
            SkillTreeScreens[i].gameObject.SetActive(true);
            scrollView.GetComponent<ScrollRect>().content = SkillTreeScreens[i].GetComponent<RectTransform>();
            BackBtn.interactable = true;
        }

        public void BackToMain()
        {
            for (int i = 0; i < SkillTreeScreens.Length; i++)
            {
                SkillTreeScreens[i].gameObject.SetActive(false);
            }

            BackBtn.interactable = false;
            MainScreen.SetActive(true);
            scrollView.GetComponent<ScrollRect>().content = MainScreen.GetComponent<RectTransform>();
        }
    }
}

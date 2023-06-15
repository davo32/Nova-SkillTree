using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NovaSkillTree
{

    public class SkillTreeSelector : MonoBehaviour
    {
        public GameObject MainScreen;
        public GameObject SkillTreeID;
        public GameObject[] SkillTreeScreens;


        [SerializeField] private GameObject scrollView;
        [SerializeField] private Button BackBtn;

        public void ChooseSkillType(int i)
        {
            MainScreen.SetActive(false);
            SkillTreeScreens[i].gameObject.SetActive(true);
            scrollView.GetComponent<ScrollRect>().content = SkillTreeScreens[i].GetComponent<RectTransform>();
            SkillTreeID.SetActive(true);
            SkillTreeID.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = SkillTreeScreens[i].name;
            BackBtn.interactable = true;
        }

        public void BackToMain()
        {
            for (int i = 0; i < SkillTreeScreens.Length; i++)
            {
                SkillTreeScreens[i].gameObject.SetActive(false);
            }

            SkillTreeID.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = " ";
            SkillTreeID.SetActive(false);
            BackBtn.interactable = false;
            MainScreen.SetActive(true);
            scrollView.GetComponent<ScrollRect>().content = MainScreen.GetComponent<RectTransform>();
        }
    }
}

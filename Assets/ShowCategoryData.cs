using UnityEngine;
using TMPro;

namespace NovaSkillTree
{
    public class ShowCategoryData : MonoBehaviour
    {
        [SerializeField] private GameObject CountModule;
        public int Count;
        public void ShowNumbers()
        {
            CountModule.SetActive(true);
            CountModule.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = Count.ToString();
        }

        public void HideNumbers()
        {
            CountModule.SetActive(false);
        }


    }
}

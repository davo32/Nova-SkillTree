using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NovaSkillTree
{
    public class SpawnNodes : MonoBehaviour
    {
        [SerializeField] private GameObject SkillNodePrefab;
        float Width;
        float Height;

        //NEEDS WORK
        private void Awake()
        {
            GameObject SO = Instantiate(SkillNodePrefab, new Vector3(0, 0, 0), Quaternion.identity, transform.parent);
            SO.transform.SetParent(gameObject.transform);
            
            SO.GetComponent<SkillUI>().SetUpgradeCount(3);
            SO.GetComponent<SkillUI>().SetBorderColor(SkillType.DAMAGE);
        }
    }
}
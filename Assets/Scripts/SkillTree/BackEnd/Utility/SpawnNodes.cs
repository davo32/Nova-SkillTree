using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NovaSkillTree
{
    public class SpawnNodes : MonoBehaviour
    {
        [SerializeField] private GameObject SkillNodePrefab;
        [SerializeField] private GameObject[] Locations;
        [SerializeField] private SkillObject[] Skills;
        //NEEDS WORK
        private void Awake()
        {
            SetupDiamond();
        }


        //Creates the node , sets the parent to the skill Tree Window , sets position based on Location Markers position
        //Sets skill component to one from the skills array
        //unlocks the first skill node be default 
        public void SetupDiamond()
        {
            for (int i = 0; i < Locations.Length; i++)
            {
                GameObject SO = Instantiate(SkillNodePrefab, new Vector3(0, 0, 0), Quaternion.identity, transform.parent);
                SO.transform.SetParent(gameObject.transform);
                SO.GetComponent<RectTransform>().SetPositionAndRotation(Locations[i].transform.position, Locations[i].transform.rotation);
                SO.GetComponent<SkillUI>().skill = Skills[i];

                if (i == 0)
                {
                    SO.GetComponent<SkillUI>().isUnlocked = true;
                }
            }
        }
    }
}
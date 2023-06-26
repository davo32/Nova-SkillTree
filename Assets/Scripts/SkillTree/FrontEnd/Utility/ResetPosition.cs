using UnityEngine;
using UnityEngine.UI;

namespace NovaSkillTree
{
    public class ResetPosition : MonoBehaviour
    {
        public Scrollbar Y;
        public Scrollbar X;
        public RectTransform Content;

        //resets the pos of the bars to their default
        public void ResetPos()
        {
            Y.value = 1;
            X.value = 1;
            Content.localScale = new Vector2(1, 1);
        }
    }
}

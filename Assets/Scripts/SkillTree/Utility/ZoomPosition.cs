using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace NovaSkillTree
{
    public class ZoomPosition : MonoBehaviour
    {
        RectTransform imageToZoom;

        float currentScale = 1.0f;

        readonly float minScale = 0.44f;
        readonly float maxScale = 2.55f;

        private void Start()
        {
            imageToZoom = GetComponent<RectTransform>();
        }

        // Update is called once per frame
        void Update()
        {
            Zoom(Input.GetAxis("Mouse ScrollWheel"));
        }

        void Zoom(float increment)
        {
            currentScale += increment;
            if (currentScale >= maxScale)
            {
                currentScale = maxScale;
            }
            else if (currentScale <= minScale)
            {
                currentScale = minScale;
            }
            imageToZoom.localScale = new Vector2(currentScale, currentScale);
        }
    }
}

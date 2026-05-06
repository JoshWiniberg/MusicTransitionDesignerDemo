using UnityEngine;

namespace MtdDemo
{
    [RequireComponent(typeof(Renderer))]
    public class ColourChanger : MonoBehaviour
    {
        private Renderer _targetRenderer;

        private void Awake()
        {
            _targetRenderer = GetComponent<Renderer>();
        }

        public void SetRandomColour()
        {
            if (_targetRenderer != null)
            {
                _targetRenderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.8f, 1f);
            }
        }
    }
}
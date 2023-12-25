using UnityEngine;
using UnityEngine.UI;


namespace TestTaskForDankolab
{
    public sealed class ContainerSizeChanger : MonoBehaviour
    {
        private RectTransform _rectTransform;
        private GridLayoutGroup _gridLayoutGroup;

        private float _cellHeight;
        private float _spaceHeight;
        
        private float _scrollHeight;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _gridLayoutGroup = GetComponent<GridLayoutGroup>();

            _cellHeight = _gridLayoutGroup.cellSize.y;
            _spaceHeight = _gridLayoutGroup.spacing.y;

            _scrollHeight = _rectTransform.parent.GetComponent<RectTransform>().sizeDelta.y;
        }

        public void ChildGone()
        {
            var newHeight = _rectTransform.sizeDelta.y - _cellHeight - _spaceHeight;

            if (newHeight < _scrollHeight)
            {
                newHeight = _scrollHeight;
            }

            _rectTransform.sizeDelta = new Vector2(_rectTransform.sizeDelta.x, newHeight);
        }
    }
}
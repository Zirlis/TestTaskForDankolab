using UnityEngine;


namespace TestTaskForDankolab
{
    public sealed class OpeningMenuButton : ButtonCore
    {
        [SerializeField] private GameObject _menuForOpening;

        protected override void ButtonMethod()
        {
            _menuForOpening.SetActive(true);
        }
    }
}
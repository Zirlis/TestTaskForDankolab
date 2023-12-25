using UnityEngine;


namespace TestTaskForDankolab
{
    public sealed class ClosingButton : ButtonCore
    {
        [SerializeField] private GameObject _menuForClosing;

        protected override void ButtonMethod()
        {
            _menuForClosing.SetActive(false);
        }
    }
}
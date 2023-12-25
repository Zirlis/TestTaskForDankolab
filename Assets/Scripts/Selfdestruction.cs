using UnityEngine;
using UnityEngine.EventSystems;


namespace TestTaskForDankolab
{
    public class Selfdestruction : ButtonCore
    {
        [SerializeField] private ContainerSizeChanger _containerSizeChanger;

        protected override void ButtonMethod()
        {
            _containerSizeChanger.ChildGone();
            Destroy(gameObject);
        }
    }
}
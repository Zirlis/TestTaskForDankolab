using UnityEngine;


namespace TestTaskForDankolab
{
    public sealed class ChangeTargetFrameRate : MonoBehaviour
    {
        private const int FRAME_RATE = 144;

        void Start()
        {
            Application.targetFrameRate = FRAME_RATE;
        }
    }
}
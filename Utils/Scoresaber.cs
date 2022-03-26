using UnityEngine;

namespace PlayFirst.Utils
{
    class Scoresaber
    {
        public static bool IsInReplay()
        {
            GameObject replayCamera = GameObject.Find("InGameReplayUI");

            if (replayCamera != null)
            {
                return true;
            }

            return false;
        }
    }
}

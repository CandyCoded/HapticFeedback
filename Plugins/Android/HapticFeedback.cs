// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace CandyCoded.HapticFeedback.Android
{

    public enum HapticFeedbackConstants
    {

        LONG_PRESS = 0,

        VIRTUAL_KEY = 1,

        KEYBOARD_TAP = 3,

        CLOCK_TICK = 4,

        CALENDAR_DATE = 5,

        CONTEXT_CLICK = 6,

        KEYBOARD_PRESS = KEYBOARD_TAP,

        KEYBOARD_RELEASE = 7,

        VIRTUAL_KEY_RELEASE = 8,

        TEXT_HANDLE_MOVE = 9,

        ENTRY_BUMP = 10,

        DRAG_CROSSING = 11,

        GESTURE_START = 12,

        GESTURE_END = 13,

        EDGE_SQUEEZE = 14,

        EDGE_RELEASE = 15,

        CONFIRM = 16,

        REJECT = 17

    }

    public static class HapticFeedback
    {

        private static AndroidJavaObject _androidPlugin;

        private static AndroidJavaObject androidPlugin
        {
            get
            {
                if (_androidPlugin != null)
                {
                    return _androidPlugin;
                }

                var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

                var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

                _androidPlugin =
                    new AndroidJavaObject("com.candycoded.hapticfeedbacklibrary.AndroidPlugin", currentActivity);

                return _androidPlugin;
            }
        }

        public static void PerformHapticFeedback(HapticFeedbackConstants hapticFeedbackConstants)
        {
            androidPlugin.Call("PerformHapticFeedback", (int)hapticFeedbackConstants);
        }

    }

}

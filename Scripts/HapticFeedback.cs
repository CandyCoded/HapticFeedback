// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

namespace CandyCoded.HapticFeedback
{

    public static class HapticFeedback
    {

        public static void LightFeedback()
        {

#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("light");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.CONTEXT_CLICK);
#endif

        }

        public static void MediumFeedback()
        {

#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("medium");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.VIRTUAL_KEY);
#endif

        }

        public static void HeavyFeedback()
        {

#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("heavy");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.LONG_PRESS);
#endif

        }

    }

}

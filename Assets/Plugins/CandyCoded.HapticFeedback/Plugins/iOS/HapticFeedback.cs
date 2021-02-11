// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Runtime.InteropServices;

namespace CandyCoded.HapticFeedback.iOS
{

    public static class HapticFeedback
    {

        [DllImport("__Internal")]
        public static extern void PerformHapticFeedback(string style = "medium");

    }

}

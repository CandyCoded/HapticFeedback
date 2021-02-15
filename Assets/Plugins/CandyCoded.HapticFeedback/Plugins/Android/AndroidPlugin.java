// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

package com.candycoded.hapticfeedbacklibrary;

import android.app.Activity;
import android.content.Context;
import android.view.HapticFeedbackConstants;
import android.view.View;

public class AndroidPlugin {

    private Context context;

    private Activity activity;

    public AndroidPlugin(Context context) {
        this.context = context;
        this.activity = (Activity)context;
    }

    public void PerformHapticFeedback(int hapticFeedbackConstant) {
        View view = activity.getWindow().getDecorView().findViewById(android.R.id.content);
        view.performHapticFeedback(hapticFeedbackConstant, HapticFeedbackConstants.FLAG_IGNORE_GLOBAL_SETTING);
    }

}

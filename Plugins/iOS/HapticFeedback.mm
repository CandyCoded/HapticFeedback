// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

extern "C"
{

    void PerformHapticFeedback(const char* style) {

        UIImpactFeedbackStyle feedbackStyle;

        const NSString* styleString = [NSString stringWithUTF8String: style];

        if ([styleString isEqualToString:@"light"]) {

            feedbackStyle = UIImpactFeedbackStyleLight;

        } else if ([styleString isEqualToString:@"medium"]) {

            feedbackStyle = UIImpactFeedbackStyleMedium;

        } else if ([styleString isEqualToString:@"heavy"]) {

            feedbackStyle = UIImpactFeedbackStyleHeavy;

        } else {

            NSException* exception = [NSException
                                      exceptionWithName:NSInvalidArgumentException
                                      reason:@"Invalid impact feedback style."
                                      userInfo:nil];

            [exception raise];

        }

        UIImpactFeedbackGenerator *feedbackGenerator = [[UIImpactFeedbackGenerator alloc] initWithStyle:feedbackStyle];

        [feedbackGenerator impactOccurred];

    }

}

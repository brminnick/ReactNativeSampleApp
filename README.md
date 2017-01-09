# ReactNativeSampleApp

This app was built in React Native to demonstrate how to create a Xamarin.UITest for an app made using React Native.

Xamarin.UITest requires that the Calabash Framework be linked to the iOS app. To accomplish, follow this [Tutorial: Link Calabash in Debug config](https://github.com/calabash/calabash-ios/wiki/Tutorial%3A-Link-Calabash-in-Debug-config).

In the JavaScript source code, add a unique identifier to each on-screen element using the `accessibilityLabel` property. [In this example](https://github.com/brminnick/ReactNativeSampleApp/blob/master/index.ios.js#L31) we've identified our TextInput as "TextInputAccessibilityId".

In the Xamarin.UITest, we can now create a field, `readonly Query TextInput`, and initialize it using the same property: [`TextInput = x => x.Marked("TextInputAccessibilityId");`](https://github.com/brminnick/ReactNativeSampleApp/blob/master/UITests/UITests/Tests.cs#L23). Now we can [interact with this on-screen element in our Xamarin.UITest](https://github.com/brminnick/ReactNativeSampleApp/blob/master/UITests/UITests/Tests.cs#L45)!

All tests were verified in Xamarin Test Cloud, and the results are viewable here:

https://testcloud.xamarin.com/test/com-minnick-samplereactnativeapp_c47fa127-61e7-4598-8134-0de14d1ad694/
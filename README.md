# NoPeeping
:no_entry_sign: :eyes: Library to remove the multitask preview image from Xamarin.iOS applications

## Why?

Depending on the kinds of apps you're building, sometimes you simply do not want any information to be visible in the Multitask preview. 
This library makes it simple to prevent this from happening.

## How?

Inheritance: Make your `AppDelegate` inherit from `ScreenshotRemovingAppDelegate` 
Composition: Override `OnResignActivation` and `OnActivate` in `AppDelegate` and forward the calls to the `IScreenshotRemover` of your preference.

## Available Removers

 - `BasicScreenshotRemover` -> Simply makes the entire window `Hidden`
 - `ViewScreenshotRemover` -> Shows a provided view as the screenshot
 - `ColorScreenshotRemover` -> Shows a color as the screenshot
 - `ImageScreenshotRemover` -> Shows a provided image as the screenshot

## But I don't even F# wtf??

You can consume this from C#, kiddo.

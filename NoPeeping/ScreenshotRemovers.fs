namespace NoPeeping

open System
open UIKit

type IScreenshotRemover =
    abstract member OnResignActivation : (UIApplicationDelegate) -> unit

    abstract member OnActivated : (UIApplicationDelegate) -> unit

type BasicScreenshotRemover() =

    interface IScreenshotRemover with

        member this.OnResignActivation(appDelegate: UIApplicationDelegate) =
            appDelegate.Window.Hidden <- true

        member this.OnActivated(appDelegate: UIApplicationDelegate) =
            appDelegate.Window.Hidden <- false
        

type ViewScreenshotRemover(view: UIView, useWindowFrame: bool) =

    interface IScreenshotRemover with

        member this.OnResignActivation(appDelegate: UIApplicationDelegate) =
            if useWindowFrame then
                view.Frame <- appDelegate.Window.Frame
            appDelegate.Window.AddSubview(view)
            appDelegate.Window.BringSubviewToFront(view)

        member this.OnActivated(appDelegate: UIApplicationDelegate) =
            view.RemoveFromSuperview()

type ColorScreenshotRemover(color: UIColor) =
    inherit ViewScreenshotRemover(new UIView(BackgroundColor = color), true)

type ImageScreenshotRemover(image: UIImage) =
    inherit ViewScreenshotRemover(new UIImageView(image), true)

type BlurScreenshotRemover() =
    inherit ViewScreenshotRemover(new UIVisualEffectView(UIBlurEffect.FromStyle(UIBlurEffectStyle.Light)), true)

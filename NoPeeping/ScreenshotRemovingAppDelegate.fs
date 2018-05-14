namespace NoPeeping

open UIKit

type ScreenshotRemovingAppDelegate() =
    inherit UIApplicationDelegate()

    member val ScreenshotRemover : IScreenshotRemover = BlurScreenshotRemover() :> IScreenshotRemover with get, set

    override this.OnResignActivation(application: UIApplication) =
        this.ScreenshotRemover.OnResignActivation(this)

    override this.OnActivated(application: UIApplication) =
        this.ScreenshotRemover.OnActivated(this)
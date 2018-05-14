namespace NoPeeping.Demo

open UIKit
open Foundation
open NoPeeping

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit ScreenshotRemovingAppDelegate ()

    override val Window = null with get, set

    override this.FinishedLaunching (app, options) =
        true

namespace NoPeeping.Demo

open System
open Foundation
open UIKit

[<Register ("ViewController")>]
type ViewController (handle:IntPtr) =
    inherit UIViewController (handle)

    override this.ViewDidLoad () =
        base.ViewDidLoad ()
        this.View.BackgroundColor <- UIColor.Red

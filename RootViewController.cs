using System;
using MonoTouch.UIKit;

namespace EmptyMonotouchSolution
{
  public class RootViewController: UIViewController {
    public RootViewController ()
    {
    }
    public override void LoadView() {
      RootView view = new RootView ();
      this.View = view;
    }
  }
}


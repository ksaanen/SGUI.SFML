using System.Collections.Generic;

namespace SGUI;
/// <summary>
/// GuiWidget is a container for grouping controls.
/// </summary>
public class Widget: Entity {
  public List<Control> Controls = new List<Control>();

  public Widget() {}

  public Widget(Control[] controls) {
    foreach(Control control in controls) {
      Controls.Add(control);
    }
  }

  public void AddControl(Control control) {
    Controls.Add(control);
  }

  public override void Draw()
  {
    // First draw this entity
    base.Draw();

    // Then draw controls on top of this widget
    foreach (Control control in Controls) {
      control.Draw();
    }
  }

}
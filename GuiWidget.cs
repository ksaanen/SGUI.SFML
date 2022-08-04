using System.Collections.Generic;

namespace SGUI;
/// <summary>
/// GuiWidget is a container for grouping controls.
/// </summary>
public class GuiWidget: GuiEntity {
  public List<GuiControl> Controls;

  public GuiWidget() {
    Controls = new List<GuiControl>();
  }

  public GuiWidget(GuiControl[] controls) {
    Controls = new List<GuiControl>();
    foreach(Control control in controls) {
      Controls.Add(control);
    }
  }

  public void AddControl(GuiControl control) {
    Controls.Add(control);
  }

  public override void Draw()
  {
    // First draw this entity
    base.Draw();

    // Then draw controls on top of this widget
    foreach (GuiControl control in Controls) {
      control.Draw();
    }
  }

}
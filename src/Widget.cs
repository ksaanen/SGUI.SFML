using System.Collections.Generic;
using SFML.Graphics;

namespace SGUI;
/// <summary>
/// GuiWidget is a container for grouping controls.
/// </summary>
public class Widget: Entity {
  public List<Control> Controls = new List<Control>();
  public WidgetAlignment Alignment = WidgetAlignment.TopLeft;

  public Widget() {}

  public override void Draw(RenderWindow window)
  {
    // First draw this entity
    base.Draw(window);

    // Then draw controls on top of this widget
    foreach (Control control in Controls) {
      control.Draw(window);
    }
  }

}
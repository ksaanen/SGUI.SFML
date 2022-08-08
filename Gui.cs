using System.Collections.Generic;

namespace SGUI;
public class Gui {
  public List<GuiWidget> Widgets;

  public Gui() {}

  public void AddWidget(GuiWidget widget) {
    Widgets.Add(widget);
  }

  public void Update() {
    foreach (GuiWidget widget in Widgets) {
      widget.Update();
    }
  }

  public void Draw() {
    foreach (GuiWidget widget in Widgets) {
      widget.Draw();
    }
  }
}

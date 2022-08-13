using SFML.Graphics;

namespace SGUI;
public class Gui {
  public List<Widget> Widgets = new List<Widget>();
  public Gui() {}

  public void Update() {
    foreach (Widget widget in Widgets) {
      widget.Update();
    }
  }

  public void Draw(RenderWindow window) {
    foreach (Widget widget in Widgets) {
      foreach (Control control in widget.Controls) {
        control.Draw(window);
      }
    }
  }
}

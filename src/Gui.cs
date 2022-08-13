using SFML.Graphics;

namespace SGUI;
public class Gui {
  public List<Widget> Widgets = new List<Widget>();
  public Gui(RenderWindow window) {}

  public void Update() {
    foreach (Widget widget in Widgets) {
      widget.Update();
    }
  }

  public void Draw() {
    foreach (Widget widget in Widgets) {
      widget.Draw();
    }
  }
}

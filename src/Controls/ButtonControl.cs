using SFML.Graphics;

namespace SGUI;
public class ButtonControl: Control {
  public Text Text;
  public Sprite Sprite;
  public ButtonControl() {}

  public override void Draw(RenderWindow window) {
    window.Draw(Sprite);
  }
}
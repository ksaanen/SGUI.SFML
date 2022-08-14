using SFML.Graphics;
using SFML.System;

namespace SGUI;
public class ButtonControl : Control
{
  public Text Text;
  public Sprite Sprite;
  public ButtonControl()
  {
    Style = new GuiStyle()
    {
      BorderColor = new Color(Color.Green),
      BorderSize = 1f,
      BorderHighlightColor = new Color(Color.Blue),
      FillColor = new Color((byte) 20, (byte) 20, (byte) 20),
      FillHighlightColor = new Color(Color.Magenta),
      TextColor = new Color(Color.Red),
      Size = new Vector2f(5f, 0)
    };

    if (Shape != null)
    {
      Shape.FillColor = Style.FillColor;
      Shape.OutlineColor = Style.BorderColor;
    }
  }

  public override void Update() {
    ApplyStyle();
  }

  public override void Draw(RenderWindow window) {
    if (Sprite != null) window.Draw(Sprite);
    if (Shape != null) window.Draw(Shape);
    //if (Text != null) window.Draw(Text);
  }

  public virtual void ApplyStyle() {
    switch (State) {
      case ControlState.Neutral:
        Shape.FillColor = Style.FillColor;
        Shape.OutlineColor = Style.BorderColor;
        break;
      case ControlState.Focused:
        Shape.FillColor = Style.FillHighlightColor;
        Shape.OutlineColor = Style.BorderHighlightColor;
        break;
      case ControlState.Clicked:
        break;
      default:
        break;
    }
  }
}
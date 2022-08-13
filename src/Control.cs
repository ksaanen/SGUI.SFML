using SFML.Graphics;

namespace SGUI;
public abstract class Control: Entity {
  public Shape Shape;
  public ControlState State;
  public FloatRect Dimensions {
    get {
      return Shape.GetGlobalBounds();
    }
  }

  public Control() {}

  public override void Update()
  {
    base.Update();
  }
}
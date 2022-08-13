using SFML.Graphics;

namespace SGUI;
public abstract class Control: Entity {
  public Shape Shape;
  public enum State { 
    Neutral,
    Focused,
    Clicked
  }
  public Control() {}
}
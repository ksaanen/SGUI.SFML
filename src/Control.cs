using SFML.Graphics;

namespace SGUI;
public abstract class Control: Entity {
  public Shape Shape;
  public ControlState State;
  
  public Control() {}
}
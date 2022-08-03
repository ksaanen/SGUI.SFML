using SFML.System;

namespace SGUI;
public abstract class GuiEntity {
  Vector2f position;

  public GuiEntity() {}

  public virtual void Update() {}

  public virtual void Draw() {}
}
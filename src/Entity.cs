using SFML.System;

namespace SGUI;
public abstract class Entity {
  Vector2f position;

  public Entity() {}

  public virtual void Update() {}

  public virtual void Draw() {}
}
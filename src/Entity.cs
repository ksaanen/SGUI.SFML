using SFML.Graphics;
using SFML.System;

namespace SGUI;
public abstract class Entity {
  public Vector2f Position;

  public Entity() {}

  public virtual void Update() {}

  public virtual void Draw(RenderWindow window) {
    
  }
}
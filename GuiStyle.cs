using SFML.Graphics;
using SFML.System;

namespace SGUI;
public struct GuiStyle {
  public Vector2f Size;
  public string BackgroundImage;

  // Fill color properties
  public Color FillColor;
  public Color FillHighlightColor;

  // Border properties
  public float BorderSize;
  public Color BorderColor;
  public Color BorderHighlightColor;

  // Text properties
  public Font TextFont;
  public int TextSize;
  public Color TextColor;
  public Color TextHighlightColor;
  public Vector2f TextPadding;
  
}
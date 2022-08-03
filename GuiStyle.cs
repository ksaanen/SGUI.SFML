using SFML.Graphics;

namespace SGUI;
public class GuiStyle {
  public Color FillColor;
  public Color FillHighlightColor;
  public Color BorderColor;
  public Color BorderHighlightColor;
  public Color TextColor;
  public Color TextHighlightColor;
  public Font Font; 
  public float BorderSize;

  public GuiStyle() {}

  public GuiStyle(Font Font, float BorderSize, Color FillColor, Color BorderColor, Color TextColor, Color FillHighlightColor, Color BorderHighlightColor, Color TextHighlightColor)
  {
      this.FillColor = FillColor;
      this.BorderColor = BorderColor;
      this.TextColor = TextColor;
      this.FillHighlightColor = FillHighlightColor;
      this.BorderHighlightColor = BorderHighlightColor;
      this.TextHighlightColor = TextHighlightColor;
      this.Font = Font;
      this.BorderSize = BorderSize;
  }
}
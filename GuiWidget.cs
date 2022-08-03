namespace SGUI;
public class GuiWidget: GuiEntity {
  public GuiControl[] Controls;
  public GuiWidget() {
    
  }

  public override void Draw()
  {
    // First draw this entity
    base.Draw();

    // Then draw controls on top of this widget
    foreach (GuiControl Control in Controls) {
      Control.Draw();
    }
  }

}
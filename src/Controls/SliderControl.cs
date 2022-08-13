using SFML.Graphics;

namespace SGUI;
public class SliderControl: Control {
  public float MinValue;
  public float MaxValue;
  public float Value;
  
  public SliderControl(float MaxValue) {
    this.MinValue = 0f;
    this.MaxValue = MaxValue;
  }
  public SliderControl(float MinValue, float MaxValue) {
    this.MinValue = MinValue;
    this.MaxValue = MaxValue;
  }
}
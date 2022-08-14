using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SGUI;

class Program {
    static void Main(string[] args)
    {
        Game game = new Game();
    }
}

public class Game {
  // Display setup
  const int PixelSize = 2;
  RenderWindow window = new RenderWindow(new VideoMode(1280, 720), "BasicMenu example");
  View view = new View(new FloatRect(0f, 0f, 1280 / PixelSize, 720 / PixelSize));
  Gui BasicMenu;

  public Game() {
    window.SetFramerateLimit(20);
    window.SetView(view);
    
    // Image button example
    BasicMenu = new Gui();
    Widget BasicWidget = new Widget();
    Sprite BasicButtonSprite = new Sprite(new Texture("./Assets/example-button-image.png"));
    ButtonControl BasicButton = new ButtonControl()
    {
      Sprite = BasicButtonSprite,
    };

    Font font = new Font("Assets/hey_comic.ttf");
    ButtonControl ShapeButton = new ButtonControl()
    {
      Shape = new RectangleShape(new Vector2f(2f, 5f)),
      Text = new Text("Button text", font),
      Position = new Vector2f(200, 60)
    };

    BasicWidget.Controls.Add(BasicButton);
    BasicWidget.Controls.Add(ShapeButton);
    BasicMenu.Widgets.Add(BasicWidget);

    Run();
  }

  public void Run() {
    while (window.IsOpen)
    {
      window.DispatchEvents();
      ProcessEvents();
      Update();
      Render();
    } 
  }

  private void ProcessEvents() {
      window.Closed += (sender, e) =>
      {
          window.Close();
      };
  }

  private void Update() {
    BasicMenu.Update();
  }

  private void Render() {
    window.Clear(SFML.Graphics.Color.Black);
    BasicMenu.Draw(window);
    window.Display();
  }
}
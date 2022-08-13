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
  const int PixelSize = 4;
  RenderWindow window = new RenderWindow(new VideoMode(1280, 720), "BasicMenu example");
  View view = new View(new FloatRect(0f, 0f, 1280 / PixelSize, 720 / PixelSize));

  //Font font = new Font("Assets/hey_comic.ttf");
  Gui BasicMenu;
  Widget BasicWidget;
  ButtonControl BasicButton;

  public Game() {
    window.SetFramerateLimit(20);
    window.SetView(view);
    
    BasicMenu = new Gui();
    BasicWidget = new Widget();
    Sprite BasicButtonSprite = new Sprite(new Texture("./Assets/example-button-image.png"));
    BasicButton = new ButtonControl()
    {
      Sprite = BasicButtonSprite,
      Shape = new RectangleShape(new Vector2f(BasicButtonSprite.GetLocalBounds().Width, BasicButtonSprite.GetLocalBounds().Height))
    };

    BasicWidget.Controls.Add(BasicButton);
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
    // Update
  }

  private void Render() {
    window.Clear(SFML.Graphics.Color.Black);
    BasicMenu.Draw(window);
    window.Display();
  }
}
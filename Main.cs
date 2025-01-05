using Raylib_cs;
using System.Numerics;

class Core
{
	public static readonly int screenWidth = 750;
	public static int screenHeight => screenWidth;
	static long unixTime = 0L;


	static long unixTimeAtStart = 0L;

	private static Ball[] balls = new Ball[2] {new Ball(), new Ball()};
	private static int BoxSize = 100;

	static void Main()
	{
		unixTimeAtStart = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();

		Raylib.InitWindow(screenWidth, screenHeight, "Raylib");
		Raylib.SetTargetFPS(60);

		while (!Raylib.WindowShouldClose()) 
		{
			unixTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();
			Raylib.BeginDrawing();
			Raylib.ClearBackground(Color.Gold);
			Raylib.DrawText("Randi", 190, 200, 20, Color.White);

			//Start
			balls[0].InstantiateBall();

			Raylib.DrawFPS(720, 20);
			Core.DrawUpdate();
			
			//End
			Raylib.EndDrawing();
		}

		Raylib.CloseWindow(); 
	}

	private static void DrawUpdate()
	{
		// Bottom Line
		Raylib.DrawLineEx(new Vector2(screenWidth /2 - BoxSize, screenHeight / 2 + BoxSize ), new Vector2(screenWidth /2 + BoxSize, screenHeight / 2 + BoxSize) , 3f, Radient());
		// Right Line
		Raylib.DrawLineEx(new Vector2(screenWidth /2 - BoxSize, screenHeight / 2 + BoxSize ), new Vector2(screenWidth /2 + BoxSize, screenHeight / 2 + BoxSize) , 3f, Radient());
	}

	private static float elapsedTime()
	{
		long currentUnixTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();
		return (currentUnixTime - unixTimeAtStart) / 1000.0f;
	}

	//Cosmetic
	private static Color Radient()
	{
		Color Radient = new Color(0f, 0f, 0f);
		return Radient;
	}
}


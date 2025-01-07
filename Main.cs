using Raylib_cs;
using System.Numerics;

class Core
{
	public static readonly int screenWidth = 750;
	public static int screenHeight => screenWidth;
	public static readonly Vector2 center = new Vector2(Core.screenWidth /2 , Core.screenWidth /2);
	static long unixTime = 0L;


	static long unixTimeAtStart = 0L;

	private static Ball[] balls = new Ball[2] {new Ball(), new Ball()};
	public static int BoxSize = 100;

	static void Main()
	{
		unixTimeAtStart = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();

		Raylib.InitWindow(screenWidth, screenHeight, "Raylib");
		Raylib.SetTargetFPS(60);

		balls[0].moveTheBall();
		while (!Raylib.WindowShouldClose()) 
		{
			unixTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();
			Raylib.BeginDrawing();
			Raylib.ClearBackground(Color.Gold);

			//Start
			balls[0].InstantiateBall();

			Raylib.DrawFPS(720, 20);
			Core.DrawUpdate();
			
			balls[0].moveTheBall();

			//End
			Raylib.EndDrawing();
		}

		Raylib.CloseWindow(); 
	}

	private static void DrawUpdate()
	{
		// center Rectangle
		//
		// Bottom Line
		Raylib.DrawLineEx(new Vector2(screenWidth /2 - BoxSize, screenHeight / 2 + BoxSize), 
				  new Vector2(screenWidth /2 + BoxSize, screenHeight / 2 + BoxSize), 3f, Radient());
		// Right Line
		Raylib.DrawLineEx(new Vector2(screenWidth /2 - BoxSize, screenHeight / 2 + BoxSize),
				  new Vector2(screenWidth /2 + BoxSize, screenHeight / 2 + BoxSize), 3f, Radient());
	}

	public static float elapsedTime()
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

using System.Numerics;
using Raylib_cs;

class Ball
{
	public static int radius = 10;
	public static Color color = new Color();
	public static float fallSpeed = 2;
	public static Vector2 position = new Vector2();
	private static int thickness = 40;
	private static int height => thickness * 2;
	private Color[] colors = new Color[2] {Color.Violet, Color.Red};

	public static bool isActive = false;

	public void InstantiateBall()
	{
		Random random = new Random();
		if (!isActive)
		{
			isActive = true;
			position = new Vector2(100 + random.Next() % Core.screenWidth - 100, 100);
			Raylib.DrawRectangleGradientV((int)position.X, (int)position.Y,
					thickness, height, 
					colors[1],colors[0]);
		} else
		{
			Raylib.DrawRectangleGradientV((int)position.X, (int)position.Y,
					thickness, height, 
					colors[1],colors[0]);
		}
	}
	public static moveTheBalls(Vector2)
	{

	}
}

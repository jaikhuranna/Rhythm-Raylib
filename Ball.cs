using System.Numerics;
using Raylib_cs;

class Ball
{
	public int radius = 10;
	public Color color = new Color();
	public static float fallSpeed = 2;
	private Vector2 position = new Vector2();
	private int thickness = 40;
	private int height => thickness * 2;
	private Color[] colors = new Color[2] {Color.Violet, Color.Red};

	public static bool isActive = false;
	public static bool isCleared = false;

	public void InstantiateBall()
	{
		Random random = new Random();
		if (!isActive && !isCleared)
		{
			isActive = true;
			position = new Vector2(Core.screenWidth /2 - thickness, Core.screenWidth + height);
		} else if (!isCleared)
		{
			Raylib.DrawCircleGradient((int)position.Y,
					thickness, height, 
					colors[1],colors[0]);
		}
	}

	public void moveTheBall()
	{
		if (isActive)
		{
			if (Vector2.Distance(this.position, Core.center) < 1f)
			{
				isCleared = true;
				isActive = false;
			}
			Vector2 pos = new Vector2(0, -1);
			Console.WriteLine(this.position);
			pos *= 3;
			this.position += pos;
		}
	}
}

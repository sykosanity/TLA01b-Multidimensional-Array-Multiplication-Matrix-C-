using Godot;
using System;

public partial class NewScript : Node
{

	public override void _Ready()
	{
		int[,] multTable = new int[11, 11];

		// Fill the multiplication table
		for (int x = 1; x < 11; x++)
		{
			for (int y = 0; y < 11; y++)
			{
				multTable[y, x] = y * x;
			}
		}

		// Print the multiplication table
		for (int y = 1; y < 11; y++)
		{
			string line = "";
			for (int x = 1; x < 11; x++)
			{
				line += $"{multTable[y, x],4}";
			}
			GD.Print(line);
		}
	}
}

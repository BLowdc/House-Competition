using Godot;
using System;

public partial class SussyBaka : Sprite2D
{
	double speed = 10;
	int direction = 1;
	
	// A function that runs when the game starts
	public override void _Ready()
	{
		GD.Print("I am a sussy baka");
	}
	
	/*
	WRITTEN BY JASON
	This function moves itself left or right every frame
	if the x value is larger than 100, it moves left by setting direction to -1
	vise versa
	*/
	
	public override void _Process(double delta)
	{
		Position += new Vector2((float)(speed * delta * direction), 0);
		if(Position[0] >= 100 && direction == 1){
			direction = -1;
		}
		else if(	Position[0] <= -100 && direction == -1){
			direction = 1;
		}
	}
}

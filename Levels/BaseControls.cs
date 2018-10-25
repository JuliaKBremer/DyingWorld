using Godot;
using System;

public class BaseControls : Godot.KinematicBody2D
{
	Vector2 UP = new Vector2(0, -1);
    Vector2 motion = new Vector2();
	bool AcceptInput = true;

    public override void _PhysicsProcess(float delta)
    {
		if(Input.IsActionPressed("ui_right")){
			motion.x = 100;
		} else if (Input.IsActionPressed("ui_left")) {
			motion.x = -100;
		} else {
			motion.x = 0;
		}
		
		if (IsOnFloor()) {
			if (Input.IsActionJustPressed("ui_up")) {
				motion.y = -400;
			}
		}
     	motion.y += 10;
		motion = MoveAndSlide(motion, UP);
    }
	
	public override void _UnhandledKeyInput(InputEventKey @event)
	{
    	if(AcceptInput) {
			System.Console.WriteLine(@event.Scancode == (int)'K');
		}
		
		AcceptInput = !AcceptInput;
	}

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}




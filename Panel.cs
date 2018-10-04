using Godot;
using System;

public class Panel : Godot.Panel
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
	private void _on_Button_pressed()
	{
	    GetTree().ChangeScene("res://Levels/Level1.tscn");
	}
}


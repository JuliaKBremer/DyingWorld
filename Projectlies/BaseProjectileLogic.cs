using Godot;
using System;

public class BaseProjectileLogic : RigidBody2D
{	
	Vector2 vector = new Vector2(100, 0);
	int damage = 10;
	
	[Signal]
	delegate void hit(Godot.Object body, int damage);
   

    public override void _Ready()
    {
        SetContactMonitor(true);
		SetMaxContactsReported(1);
		
        
    }
	
	private void _on_RigidBody2D_body_entered(Godot.Object body)
	{
    	EmitSignal("hit", body, damage);
		destroy();
	}
	
	private void destroy() {
		QueueFree();
	}
	
	private void _on_Timer_timeout()
{
    // Replace with function body
}

}


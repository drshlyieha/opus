using Godot;
using System;

public partial class new_script : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{string ksa= "再生反应堆";
	this.GetNode<Label>("Label").Text = ksa;
	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	
	}
}

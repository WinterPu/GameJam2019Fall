using UnrealBuildTool;

public class MyEscapeGameTarget : TargetRules
{
	public MyEscapeGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyEscapeGame");
	}
}

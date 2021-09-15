// Shoot Them Up Game, All Rights Reserved 

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUp_MTarget : TargetRules
{
	public ShootThemUp_MTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ShootThemUp_M" } );
	}
}

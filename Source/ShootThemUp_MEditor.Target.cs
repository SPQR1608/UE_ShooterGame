// Shoot Them Up Game, All Rights Reserved 

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUp_MEditorTarget : TargetRules
{
	public ShootThemUp_MEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ShootThemUp_M" } );
	}
}

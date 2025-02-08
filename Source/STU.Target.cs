// STU Game.All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class STUTarget : TargetRules
{
	public STUTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "STU" } );
	}
}

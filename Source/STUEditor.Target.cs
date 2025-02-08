// STU Game.All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class STUEditorTarget : TargetRules
{
	public STUEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "STU" } );
	}
}

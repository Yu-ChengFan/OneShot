// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class OneShotProjectTarget : TargetRules
{
	public OneShotProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "OneShotProject" } );
	}
	public void SteamIntegrationTutTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
		bUsesSteam = true;
	}

}


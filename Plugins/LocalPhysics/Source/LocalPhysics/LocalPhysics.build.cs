// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LocalPhysics: ModuleRules
{
	public LocalPhysics(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
                "Engine",
                "AnimGraphRuntime",
                "PhysX",
                "PhysicsCore"
			}
		);

        PrivateIncludePaths.AddRange(
            new string[] {
                "Runtime/LocalPhysics/Private"
            });
    }
}

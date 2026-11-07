// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class TP_TopDown : ModuleRules
{
	public TP_TopDown(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		// Include paths are module-relative because the module now lives inside a plugin
		// 因为模块现在位于插件内，包含路径改为相对于模块目录
		PublicIncludePaths.AddRange(new string[] {
			ModuleDirectory,
			Path.Combine(ModuleDirectory, "Variant_Strategy"),
			Path.Combine(ModuleDirectory, "Variant_Strategy", "UI"),
			Path.Combine(ModuleDirectory, "Variant_TwinStick"),
			Path.Combine(ModuleDirectory, "Variant_TwinStick", "AI"),
			Path.Combine(ModuleDirectory, "Variant_TwinStick", "Gameplay"),
			Path.Combine(ModuleDirectory, "Variant_TwinStick", "UI")
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

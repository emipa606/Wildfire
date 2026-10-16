# GitHub Copilot Instructions for Wildfire (Continued) Mod Development

## Mod Overview and Purpose

**Wildfire (Continued)** is a RimWorld mod initially developed by pelador and now maintained as a continued project. The primary objective of this mod is to allow fires in the game to spread more naturally, without the game's default intervention to expedite rain when large fires are detected. By disconnecting this link, the mod provides a more dynamic and variable response to fires based on the game's normal weather patterns, resulting in a more immersive experience when dealing with fire-related events on the map.

## Key Features and Systems

- **Natural Fire Spread**: The mod removes restrictions that cause rain to rapidly appear when significant fires occur, allowing for a more realistic fire management experience.
- **Toggleable Feature**: Users can toggle the mod's functionality on or off via an in-game option. Note that disabling the feature will delay the "Fire watcher" behavior from remaining active based on prior settings.
- **Safe Installation and Removal**: The mod can be safely added to or removed from a save game without adverse effects.
  
## Coding Patterns and Conventions

- **C# Code Structure**: The mod uses organized C# files to encapsulate different functionalities.  Each file has types and members that define its primary function, such as settings management or the implementation of specific Harmony patches.
- **Consistency and Readability**: Ensure consistency in naming conventions and maintain clarity in the code to enhance readability and future modifications.
  
## XML Integration

While this mod does not currently include XML files, XML integration in RimWorld mods would typically involve defining new game entities, items, or behaviors. Ensure that any XML files follow RimWorld’s schema and are loaded correctly by specifying them in your `About.xml`.

## Harmony Patching

The mod utilizes Harmony, a library that facilitates runtime method patching in C#. The Harmony patches are essential for modifying the default Fire Watcher behavior. Key Harmony components include:

- **Patch Classes**: Define classes specifically for applying Harmony patches. For example, `FireWatcher_UpdateObservations` class includes a `Postfix` method that changes the default behavior after the original method executes.
- **Applying Patches**: Use a central file, such as `HarmonyPatching.cs`, to gather and apply all Harmony patches associated with the mod.

## Suggestions for Copilot

- **Automated Patching**: Suggest automating the process for checking if patches are correctly applied and throw informative errors if required objects or methods are not available.
- **Settings Synchronization**: Propose creating helper methods for synchronizing mod settings with in-game options to enhance user interactions.
- **Logging and Debugging**: Implement comprehensive logging mechanisms that notify mod developers about the current state of the patches and options.
- **Code Comments and Documentation**: Use comments extensively to document the purpose of each class and method, improving code understandability.

By adhering to these suggestions and best practices, you can enhance the robustness and user-friendliness of the Wildfire (Continued) mod, ensuring a smooth development process and enjoyable gameplay experience.

---

*For any encountered issues, please utilize the Log Uploader for error reporting and use the Discord channel specified for support. Avoid creating discussion threads for error reporting due to notification constraints.*

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.


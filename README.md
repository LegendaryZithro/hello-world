# hello-world

Comp Sci Major looking to get a head start in coding before classes start.

## Diablo-Themed 3D Isometric Game Setup for Steam

This brief guide outlines how you can create a Diablo-inspired 3D isometric game
and package it for release on Steam. The instructions assume you will use the
Unity game engine, although similar steps apply to other engines like Unreal.

1. **Install Unity**  
   Download and install the latest version of Unity Hub and create a new 3D
   project. Choose the built-in render pipeline or URP depending on your
   preference.

2. **Create an Isometric Scene**  
   - Set up your camera with an isometric projection using a 45\u00b0 rotation on
     the Y-axis and a 30\u00b0 angle on the X-axis.  
   - Import or model your environment with a tile-based approach so the scene
     aligns with the isometric view.  
   - Use Diablo-inspired textures and models that you have rights to, or design
     your own to capture a dark, gothic atmosphere.

3. **Add Gameplay Components**  
   - Implement player controls that allow for click-to-move navigation.  
   - Create basic enemy AI that uses pathfinding and simple attack behavior.  
   - Add loot or inventory systems to mirror the hack-and-slash feel of Diablo.

4. **Integrate with Steam**  
   - Sign up for Steamworks and follow the documentation to configure your
     Steam app ID.  
   - Import the Steamworks SDK package into your Unity project.  
   - Set up achievements, cloud saves, and other Steam features through the
     SDK.  
   - Build your game for Windows and upload the build to your Steam account.

5. **Iterate and Polish**  
   - Playtest frequently, refine combat and skills, and ensure the isometric
     camera feels responsive.  
   - Optimize performance and package your assets efficiently before your final
     Steam release.

This guide should help you get started on a Diablo-styled game that can run on
Steam. For further details, consult Unity and Steamworks documentation.

## Sample Unity Scripts

This repository includes minimal C# scripts found in `Assets/Scripts` that 
provide a starting point for a Diablo-inspired game:

- `IsometricCamera.cs` – keeps the camera positioned at an isometric angle while following the player.
- `PlayerController.cs` – implements click-to-move navigation using Unity's NavMesh system.
- `EnemyAI.cs` – simple AI script for enemies that chase the player when nearby.

These scripts are intentionally lightweight so you can expand them with your own gameplay systems. Create a new Unity project and copy the `Assets` folder contents into it. Configure NavMesh surfaces in your scene and attach the scripts to your camera, player, and enemy prefabs.

To integrate Steam features, import the Steamworks SDK into your project and follow its documentation to initialize the API and manage achievements or other services.

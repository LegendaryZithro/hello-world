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

This repository now includes a few example C# scripts located under `Assets/Scripts`.
Add them to your Unity project to quickly get started:

- **IsometricCamera.cs** – keeps the camera positioned in an isometric view while following the player.
- **PlayerController.cs** – implements basic click-to-move navigation using Unity's NavMesh system.
- **EnemyAI.cs** – provides a simple enemy chase behavior when near the player.
- **GameManager.cs** – singleton class for managing game state and initialization.
- **Inventory.cs** – minimal inventory component for storing picked up items.

These scripts are intentionally lightweight so you can expand them with your own gameplay systems.

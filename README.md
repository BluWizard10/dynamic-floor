# Dynamic VRC Floor Collider

## HOW IT WORKS

Using a VRC Constraint, it ensures that the attached PhysBone Collider (Plane) will remain on the Floor whenever you jump. This allows Tails to look more natural as you jump and move around the World.

## REQUIREMENTS

- Latest VRChat Avatars SDK `3.7.0` or newer.
- [VRCFury](https://vrcfury.com/download) `1.980.0` or newer.

## INSTALL

1. [Add the BluWizard LABS VCC Repository](https://vpm.bluwizard.net).
2. [Add the VRCFury Repository](https://vrcfury.com/download), if you haven't already.
3. Add the `BluWizard LABS - Dynamic VRC Floor Collider` Package to your project. It will automatically add the latest version of VRCFury for you as well, since it's a vpmDependency. If necessary, this will also force an upgrade of the SDK to the minimum required version for this system to work.
4. Launch the Project. Then, select the Avatar in your Scene and do either of the following:
   1. Click `BluWizard LABS -> Add Dynamic Floor Collider to Avatar` from the Unity Menu Bar.
   2. OR `Right-Click` on the Avatar in your Hierarchy and click `BluWizard LABS -> Add Dynamic Floor Collider to Avatar` from the context menu.
5. The Prefab should be instantly added to your Avatar and will be pinged in the Editor for you to see where it is. A Debug Log message will also print into the Console indicating it was successfully added.
6. If necessary, change the references for your existing Tail PhysBones, among others, to reference the `Floor` PhysBone Collider inside the Prefab. It's located at `Dynamic VRC Floor -> VRC World Constraint -> Container -> Floor` in the Hierarchy.
7. Upload and done! VRCFury will take care of the rest.

## USAGE

The function is automatic! Whenever you "Jump" in-game, the VRChat Parameter `Grounded` will change to `false`, which triggers the Container to disable itself. This makes it lock the Floor Collider to where you jumped from. As it's Freezed on the Y-axis, the Floor Collider will only travel with you on the X and Z axis in Unity. The Animator was carefully designed to ensure it activates instantly so that there's no latency on each end.

It will continue to stay locked to the Ground until one of the following conditions are met:
1. You land on the Ground again, triggering the `Grounded` VRC Parameter to change back to `true`. This will reset it's Axis to follow your Avatar again.
2. You begin falling down at an excess of 4 meters per second, which would be `VelocityY <= -4`. If this happens, the Floor Collider will reset itself to follow your Avatar again (preventing your Tail from looking weird when falling).

Additionally, this Floor Collider adds a Toggle to your VRChat Menu. Find it under `Blu's Add-ons/Floor Collider` in your VRChat Menu.
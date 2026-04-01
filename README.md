# Dynamic VRC Floor Collider

## HOW IT WORKS

Using a VRC Raycast, it ensures that the attached PhysBone Collider (Plane) will remain on the Floor whenever you jump. This allows Tails to look more natural as you jump and move around the World.

## REQUIREMENTS

- Latest VRChat Avatars SDK `3.10.3` or newer.

## INSTALL

1. [Add the BluWizard LABS VCC Repository](https://vpm.bluwizard.net).
2. Add the `BluWizard LABS - Dynamic VRC Floor Collider` Package to your project. If necessary, this will also force an upgrade of the SDK to the minimum required version for this system to work.
3. Launch the Project. Then, select the Avatar in your Scene and do either of the following:
   1. Click `BluWizard LABS -> Add Dynamic Floor Collider to Avatar` from the Unity Menu Bar.
   2. OR `Right-Click` on the Avatar in your Hierarchy and click `BluWizard LABS -> Add Dynamic Floor Collider to Avatar` from the context menu.
4. The Prefab should be instantly added to your Avatar and will be pinged in the Editor for you to see where it is. A Debug Log message will also print into the Console indicating it was successfully added.
5. If necessary, change the references for your existing Tail PhysBones, among others, to reference the `Floor` PhysBone Collider inside the Prefab. It's located at `Dynamic VRC Floor -> Floor` in the Hierarchy.
6. Upload and done!

## USAGE

The function is automatic thanks to VRC Raycasting! Whenever you "Jump" in-game, the Raycast will move the Floor Collider's Transform to whichever position the Raycast hits in the World. This makes it lock the Floor Collider to where you jumped from. As it makes it look like it's locked to the Y-axis, the Floor Collider will only travel with you on the X and Z axis in Unity.

It will continue to stay attached to whichever collider the Raycast hits in the world unless the conditions are met:
1. The Raycast sees no collider, which will make the Collider assume the floor is at the tip-end of the Raycast.
2. The Floor Collider will be disabled when it detects no collider.

Additionally, if you use VRCFury, this Floor Collider adds a Toggle to your VRChat Menu. Find it under `Blu's Add-ons/Floor Collider` in your VRChat Menu. It does require VRCFury, but you can remove this yourself if you're not going to use it.
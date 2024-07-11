# Dynamic VRC Floor Collider

## HOW IT WORKS

Using a VRC Constraint, it ensures that the attached PhysBone Collider (Plane) will remain on the Floor whenever you jump. This allows Tails to look more natural as you jump and move around the World.

## REQUIREMENTS

- Latest VRChat Avatars SDK `3.6.2-constraints.1` or newer.
- [VRCFury](https://vrcfury.com/download) `1.980.0` or newer.

## INSTALL

1. [Add the BluWizard LABS VCC Repository](https://vpm.bluwizard.net).
2. [Add the VRCFury Repository](https://vrcfury.com/download), if you haven't already.
3. Add the `BluWizard LABS - Dynamic VRC Floor Collider` Package to your project. It will automatically add the latest version of VRCFury for you.
4. Launch the Project. Then, navigate to the folder `Packages/BluWizard LABS - Dynamic VRC Floor Collider`.
5. Drag & Drop the `Dynamic Floor.prefab` into your Avatar.
6. If necessary, change the references for your existing Tail PhysBones, among others, to reference the `Floor` PhysBone Collider inside the Prefab.
7. Upload and done! VRCFury will take care of the rest.
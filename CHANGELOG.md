# v0.3.0-beta
- Added Editor Script that will install the Prefab automatically.
  - Simply select your Avatar in the Scene, then activate the script from the Unity Menu via `Tools -> BluWizard LABS -> Add Dynamic Floor Collider to Avatar`.
  - You can also do the same thing by `Right-Clicking` on your Avatar and by clicking `BluWizard LABS -> Add Dynamic Floor Collider to Avatar` in the context menu.

# v0.2.1-beta
- Fixed broken Source on Prefab due to breaking changes on SDK `3.6.2-constraints.3` version.
- Bumped minimum version requirement of `VRChat SDK - Avatars` to `3.6.2-constraints.3`.

# v0.2.0-beta
- Added Toggle for the Floor Collider, located in the Expressions Menu as `Blu's Add-ons/Floor Collider`.
- Removed the old `World` Object as a Source for the World Constraint, as it no longer needs a Source for the World Constraint to work as of SDK `3.6.2-constraints.2` version. [Feedback Post](https://feedback.vrchat.com/open-beta/p/1471-freeze-to-world-doesnt-work-if-parent-constraint-has-0-sources)
- VRC Constraint's `Freeze To World` function will now only lock the selected Axis under `Constraint Settings` instead as of SDK `3.6.2-constraints.2` version, eliminating the requirement for a `World` Object Source to control selected Axis. [Feedback Post](https://feedback.vrchat.com/open-beta/p/vrc-constraints-freeze-world-axis-should-only-freeze-the-selected-axis-in-the-co)
- Bumped minimum version requirement of `VRChat SDK - Avatars` to `3.6.2-constraints.2`.
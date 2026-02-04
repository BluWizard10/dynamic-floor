# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.2.2]
### Changes
- Updated Icons.
- Updated Dependencies.
- Fixed Workflow Dispatch to exclude .git directories.

## [1.2.1]
### Changes
- Changed location of Editor Script to under `Tools`.

## [1.2.0]
### Changes
- Prefab is now self-contained. This should allow you to place the Prefab anywhere in an organized Empty GameObject hierarchy. That is, if you're an organized freak like me.
- Animation files were updated.
- Bumped minimum version requirement of `VRChat SDK - Avatars` to `3.7.5`.
- Bumped minimum version requirement of `VRCFury` to `1.1155.0`.

## [1.1.0]
### Changes
- Added `InStation` condition to Animator Controller. This should stop the Floor Collider from being frozen when entering a VRC Station or Seat.
- Re-added Menu Icons to the same Package directory.
- Removed `net.bluwizard.source` as a VPM Dependency, as it's not necessary for a lightweight package.

## [1.0.0]
### Changes
- Initial Release.
- Bumped minimum version requirement of `VRChat SDK - Avatars` to `3.7.0`.

## [1.0.0-beta.3]
### Changes
- Updated Log Message on successful script run with syntax color.

## [1.0.0-beta.2]
### Changes
- Changed location of Script in the Unity Menu Bar to be under it's own `BluWizard LABS` Menu instead.

## [1.0.0-beta.1]
### Changes
- RELEASE CANDIDATE.

## [0.3.0-beta]
### Changes
- Added Editor Script that will install the Prefab automatically.
  - Simply select your Avatar in the Scene, then activate the script from the Unity Menu via `Tools -> BluWizard LABS -> Add Dynamic Floor Collider to Avatar`.
  - You can also do the same thing by `Right-Clicking` on your Avatar and by clicking `BluWizard LABS -> Add Dynamic Floor Collider to Avatar` in the context menu.

## [0.2.1-beta]
### Changes
- Fixed broken Source on Prefab due to breaking changes on SDK `3.6.2-constraints.3` version.
- Bumped minimum version requirement of `VRChat SDK - Avatars` to `3.6.2-constraints.3`.

## [0.2.0-beta]
### Changes
- Added Toggle for the Floor Collider, located in the Expressions Menu as `Blu's Add-ons/Floor Collider`.
- Removed the old `World` Object as a Source for the World Constraint, as it no longer needs a Source for the World Constraint to work as of SDK `3.6.2-constraints.2` version. [Feedback Post](https://feedback.vrchat.com/open-beta/p/1471-freeze-to-world-doesnt-work-if-parent-constraint-has-0-sources)
- VRC Constraint's `Freeze To World` function will now only lock the selected Axis under `Constraint Settings` instead as of SDK `3.6.2-constraints.2` version, eliminating the requirement for a `World` Object Source to control selected Axis. [Feedback Post](https://feedback.vrchat.com/open-beta/p/vrc-constraints-freeze-world-axis-should-only-freeze-the-selected-axis-in-the-co)
- Bumped minimum version requirement of `VRChat SDK - Avatars` to `3.6.2-constraints.2`.
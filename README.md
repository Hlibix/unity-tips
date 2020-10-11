# Editor


## Expand/Collapse All

`Alt+Left Click` on a game object in the hierarchy to expand or collapse all its children game objects


## Scene View Settings

*   Shading Modes
*   2D View Mode
*   Scene Lighting
*   Effects Toggles
*   Scene Camera Settings
    *   Dynamic Clipping
*   Gizmos
    *   2D/3D Icons
    *   Selection Wire
    *   Selection Outline


## Tags/Layers Submenus

You can make tag/layer folders by writing the folder(s) name in front of the tag or layer, e.g.: `Characters/Enemy`, `Characters/Player`


## Color Picker

The colour picker works for in any window


## Inspector Math

Any numeric inspector value can be changed not by simply rewriting the value, but also by executing mathematical operations, e.g.: `2+2`, `2*2`, etc.


## Snapping

`Ctrl+Drag` in scene view using any transform tool (move, rotate, scale) to change the value in steps. Goto `Edit->Grid and Snap Settings` to change the step


### Vertex snapping

Hold `V` when using the move tool to drag and snap the object by the objects mesh vertex, press `Shift+V` to toggle this mode on/off


## Debug inspector

Click three vertical dots on the right of the `Inspector` and click `Debug` to see the private values of your scripts


## Scene View Icon

To make the invisible game object seen in the scene, click the box to the left of the object name in the inspector and choose either the built-in or `Other` gizmo


## Search By Component In Scene

Write the name of your script as it is written in the script file (class name) to select all objects that have it attached. Also works with default components such as `BoxCollider`, `TextMeshProUGUI`, etc.


## Quick Search

In `Window->Package Manager` in Unity Registry install the `Quick Search` and after click `Alt+’` to access the almighty search


## Stored Selection

Choose the object(s) that you want to select quick and goto `Edit->Selection->Save Selection x` (or use the keyboard shortcut) to store this selection. Goto `Edit->Selection->Load Selection x` to restore the stored selection


## Local/Global, Center/Pivot

To the right of the transform tools, you will find two buttons: `Pivot`/`Center` and `Local`/`Global`.

*   `Pivot` mode will apply all the transform actions using the pivot point as an anchor. Having multiple objects selected and applying scaling/rotation will cause each of the objects to scale/to rotate individually from each pivot point
*   `Center` mode will apply all the transform actions using the centre as an anchor. Having multiple objects selected and applying scaling/rotation will make the selected objects behave as a single object and will scale/rotate properly

* `Local` mode will align the transform handles according to the local position of the game object
* `Global` mode will align the transform handles according to the `(0,0,0)` point


## Game view Gizmos

In the game mode, click `Gizmos` on the top right to see all the gizmos that you usually see only in the scene view (including `physics debugger`)


## Physics Debugger

Goto `Windows -> Analysis -> Physics Debugger` and dock it anywhere to see all the colliders in scene or game mode (with gizmos turned on)


## Match Camera with Scene View

Choose the camera game object and goto `GameObejct -> Align View with Selected` (or press `Ctrl+Shift+F`) to place the camera in a way that you see the scene at the moment. Applying this to non-camera objects will put them in a place where the virtual scene camera is at the moment


### Match Scene View with Camera

To see the scene as the camera sees it: select the camera and select `GameObject -> Move to View`


## Toggle Game Object Active Hotkey

    Alt+Shift+A

## Focus

Pressing `F` in Scene View having an object selected will move the camera in the middle of the viewport. `F+F` (or `Shift+F`) will continue to follow this object if it moves. You can rotate the scene camera, but not move it to continue focusing


## Editor Tint

`Edit -> Preferences -> Colors -> General -> Playmode Tint` will change the colour of the editor while in play mode


## Disable Auto Lighting Baking

If you constantly feel the lag after moving objects in the scene, check if you see the `Baking…` line on the bottom left of the editor. If you found it - goto `Windows -> Rendering -> Lighting` and uncheck `Auto Generate` on the bottom right of the window


## Copy-Paste Components

Click the three dots to the left of the component name and click `Copy Component` to copy it (do it in play mode to save and apply them in edit mode after you’ve changed them). Click on the three dots again and choose `Paste Component Values` to paste saved values. Choose `Paste Component as New` to add the component as a copy of the copied (delete the copied and paste as new to imitate the “extract” of the component)


## Add Tab

Click on three dots of any editor window and navigate to `Add Tab` to add a copy of any standard window (useful for having one locked inspector and one unlocked)


## Ultimate Transform Tool

Press `Y` or select last but one tool to use the three-in-one move, scale and rotate tool


## Layer Locking

Click on the `Layers` on the top right to toggle visibility or selectability of individual layers in the scene


## Dark Mode

Apply to `Unity Student Programme` to be able to use editor dark mode


# Programming


## Attributes

### Range
Add `[Range(minValue,maxValue)]` to numeric fields to show a slider between `minValue` and `maxValue` in the inscpector (`minValue` and `maxValue` should be actual numbers)

### Space

Add `[Space]` or `[Space(number)]` on top of a field to add a space between this and previous field in the inspector

### Tooltip

Add `[Tooltip("text")]` on top of a field to add a text appear when hovered over current field in inspector

### Header

Add `[Header("text")]` on top of a field to add a bold text header over current field in the inspector

### Naughty Attributes

Use [Naughty Attributes](https://github.com/dbrizov/NaughtyAttributes) to add even more useful attributes to your inspector 


## CompareTag

Instead of writing `object1.tag == object2.tag` or `object1.tag == someTag` instead write `object1.CompareTag(object2.tag)` or `object1.CompareTag(someTag)`

## Gizmos

Implement a `void OnDrawGizmos(){//Gizmo code}` or `void OnDrawGizmosSelected(){//Gizmo code}` in your `MonoBehivour` scripts to draw helper graphic elements in the scene mode (or play mode with gizmos enabled). Most often used methods are: `Gizmos.DrawRay/DrawLine/DrawSphere/DrawWireSphere`. To change the color of the gizmo write `Gizmos.color = yourColor` right before calling a `Gizmos.DrawX` method

## String Interpolation

Instead of writing `Debug.Log("Speed: " + speed);` use a C# string interpolation feature: `Debug.Log($"Speed: {speed}");`. Use it to format a string anywhere in the code

# Yes

[https://www.youtube.com/watch?v=wWiDR8pLMso](https://www.youtube.com/watch?v=wWiDR8pLMso)

[https://www.youtube.com/watch?v=Z3-ml774vwE](https://www.youtube.com/watch?v=Z3-ml774vwE)




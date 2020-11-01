# Getting ready

## Rider in Unity setup

After installing Rider goto Unity->Edit->Preferences->External Tools and set **External Script Editor** to **Rider**

## DOTween installation

Goto [DOTween Asset Store page](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676.), click **Add to My Assets**, click **Open in Unity**, and in Unity click **Install** then **Import**. After this click **Open DOTween Setup**->**Setup DOTween...**->(wait until interactable)->**Apply**

# Rider

All hotkey settings are located in **Settings**->**Keymap** (try starting with **ReSharper** keymap)

## Most used hotkeys

* **Scroll Up/Down** -- `Ctrl+Up/Down Arrow`, scrolls the document without change the cursor position
* **Move Caret to Line Start / End** -- `Home` and `End` are too far from your *active* zone, so change it to some `Ctrl/Alt/Shift` shortcut (I use `Alt+A/E`)
* **Delete to Word Start** -- `Ctrl+Backspace`, deletes the whole word from the current cursor position
* **Select Previous/Next Tab** -- `Alt+Left/Right Arrow`, navigates you to previous/next open file
* **Start New Line** -- `Shift+Enter`, creates a new line ***below*** current and moves a cursor there
* **Start New Line Before Current** -- `Ctrl+Enter`, creates a new line ***above*** current and moves a cursor there 
* **Close Active Editor** -- set this to close a currently viewed file (I set it to `Alt+W`)

## Most used features

* **Almighty Search** (Search Everywhere) -- `Shift-Shift`
* **Reformat Code** -- `Ctrl+Alt+L`
* **Rename...** -- press `F2` while the cursor is at any class, variable, field, etc. name to rename it everywhere in the code in one click
* **Code Completion** -- `Ctrl+Space` to see the list of available variables/methods (functions)
* **Show Context Actions** -- `Alt+Enter` to see the actions available for current piece of code
* **Parameter Info** -- shows all possible parameters (including descriptions) of the current method (I set it to `Ctrl+P`)
* **CamelCase completion** -- any name that follows *CamelCase* is recognized by Rider which allows the quick typing (e.g.: write `go` and you'll see the `gameObject` as a first element in the list)
* **Hungry Backspace** -- instead of pressing Backspace a lot, just remove the default hotkey from **Backspace** keymap and set `Backspace` as a shortcut to **Hungry Backspace**
* **Move Line Up/Down** -- I set it to `Shift+Alt+Up/Down Arrow`
* **Move Statement Up/Down** / **Move Element Left/Right** -- press `Ctrl+Alt+Shift+Arrow Key` to move the whole block of code in the corresponding direction
	* **Up/Down**:
	* While over ***method (function)*** -- will move the whole method above/below another
	* While over ***line*** -- will move the whole statement (until the `;`) up/down
	* **Left/Right**:
	* While over ***method (function) argument*** (both when writing a method and when calling) -- will swap current and previous/next arguments

## Useful tweaks

Goto **Settings**->General->Code Completion, and set both `Show the documentation popup in` and `Show the parameter info popup in` so that the popups appear immediately

## Live Templates

### for/foreach

Start typing `for`/`foreach` and hit enter to insert a template for the corresponding loop
>or

If you have an array/list/dictionary/etc. you want to loop over, write `yourList.for/foreach` and hit `Enter` to automatically fit the loop to `yourList`, e.g.:

```csharp
List<Transform>() points;

points.foreach 

// Pressing Enter will transform to following:

foreach (var point in points)  
{  
	//Cursor point
} 
```

### sfield

Creates `[SerializedField] private SomeType someField;`

### log/logerr/logex/logwarn

Creates `Debug.Log/LogError/LogException/LogWarning(CURSOR);`

## Plugins

* [**Solarized themes**](https://plugins.jetbrains.com/plugin/12784-solarized-themes) -- scientifically tailored color scheme
* [**Cognitive Complexity**](https://plugins.jetbrains.com/plugin/12024-cognitivecomplexity) -- shows us how complex the function you are writing is

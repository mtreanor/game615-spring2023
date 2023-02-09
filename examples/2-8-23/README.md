This is a rather odd collection of demos, but there are many important concepts that will help you with your exercise. Note that many of the scripts described below require that the public variables are assigned values via the inspector within Unity.

### Assets/PlaneScript.cs
This is a simple script that moves a plane forward while constants slowly rotating. Look to these two lines in particular for help:
```
gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
```

### Assets/BananaCarCounterScript.cs
This files shows how to display the value of a variable on a UI element. Note that we needed to add the line "using TMPro;" to the top of the file to enable us to reference UI elements, and also that we assign the value for the bananaCarCount TMP_Text variable in the inspector by dragging and dropping the UI GameObject with the TextMeshPro Text component on it.

### Assets/DemoScript.cs
This file mostly demonstrates how you can instantiate and configure prefabs from within a script.

### 2-8-23.unitypackage
Import this into your Unity package and load the included scene to get access to project as I demonstrated in class.
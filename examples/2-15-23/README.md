# [Link to unityproject](https://www.dropbox.com/s/h23811iqypplbom/2-15-23.unitypackage?dl=0)


## Terrains
* Create a terrain
* Raise and lower (using the tools)
* Texturing:
    * Get the texture pack from Unity's Asset store "Outdoor Ground Textures"
        * Remember to sign in
    * Load it using Package Manager's "My Assets"
    * Paint Texture by adding Terrain Layers (and assigning Textures form the Outdoor Ground Texture package)
    * Add Normal maps to the layers (these are also from the Outdoor Ground Texture package)

## ProBuilder
* Get it the Package Manager's "Unity Registry"
* Getting and positioning the ProBuilder tool window (Tools->ProBuilder->ProBuilder Window)
* Basics of 3d models: vertices, edges, faces, normals
* Creating and modifying ProBuilder shapes
* Modeling techniques
    * Bevel
    * Extrude
    * Cutting faces with the cut tool
    * Many others
* Creating a room by creating a shaped and flipping normals
* Coloring faces (or individual vertices) with vertex coloring
* Creating a custom material to make it so it doesn't have the measurement texture (create a material, select the ProBuilder shader, and assign it like a regular material)

## Starter Assets
* Get it from the Asset Store (search starter assets)
* Choose either first person and third person
* When you import, it will ask you if you want to switch to yhe "new" input system - say OK.
* Add the NestedParent_Unpack, and unpack, and position the PlayerCapsule
    * Delete the UI/event stuff
* Delete the original Main Camera
* Read the manual for more details

## Particle Effects
* Create an empty game object
* Add the "Particle System" component to it
* Download [this image](https://catlikecoding.com/unity/tutorials/custom-srp/particles/unlit-particles/particles-single.png), and add it to the assets folder in your project
* To make it so the magenta square is replaced with a more usable shape, create a material, select the correct shader (Particle->Standard Unlit), and assign the following image to the materials "Albedo"
* Apply the material to the Particle System by expanding the Renderer area of the inspector for the Particle System, and drag the material into the Material slot
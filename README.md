# ARTableTennis

This project was developed in Unity with ❤️

[![Watch the video](https://img.youtube.com/vi/lqUcLbSprxQ/maxresdefault.jpg)](https://youtu.be/lqUcLbSprxQ)
[Watch the video👆🏻](https://youtu.be/lqUcLbSprxQ)


## Unity Packages :
- ARFoundation
- XRInteractionToolkit
- ARKit XR Plugin

## Running the scene in Unity Editor:
- Scenes > ARScene > Play button
- Scenes > ARTableTennis > Play button
- Scenes > SampleScene > Play button

## Scenes description
- **ARScene** - uses ARFoundation to place a prefab in the user's environment. 
- **ARTableTennis** - uses XRInteractionToolkit setup to place a prefab in a user's environment
- **SampleScene** - a visualization scene before trying the experience in AR  

## Before Deploying to a device
- If you build the AR scenes with XCode and deploy on your IOS device, make sure you deactivate or remove the **"ARTable"** Game Object from the scene. This was included to test whether the bots are actually being able to play or not in a regular scene. 

## Note 
Testing in AR can be tedious due to the constant build and deploy method AR Developers need to use. AR Developers need a feature like Google's ARCore instant preview mode integrated within Unity and workable with ARFoundation. 

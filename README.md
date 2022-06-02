# Procedural Dungeon
The project is a 3D procedural dungeon generator with an essential AI system. It is aimed for use as an asset in the game and 3D production. The project contains the generator created from SideFX Houdini and the example game scene set up in Unity. 

![Unity_DungeonPlay](https://user-images.githubusercontent.com/67904518/171596737-b29cbb96-62b8-4664-9945-364158c3a01d.jpg)

Houdini Engine is used for the workflow of this project. Simply drag the HDA file into the scene to use it. It allows the access of parameters and attribute controls directly from Houdini. By changing the value of the generator, the model can be update easily. 
![Unity_Workflow](https://user-images.githubusercontent.com/67904518/171615468-acf42870-6a29-46b2-85ed-3d50f171ab61.png)
To active the Houdini Engine plugin in Unity, a Houdini license is needed. The Houdini HDA file need to be exported from a paid version of Houdini. And the file will not load in the Unity scene when opening with the device do not have a valid Houdini license installed. The project is using the Houdini Education license. 

![Houdini_Viewport](https://user-images.githubusercontent.com/67904518/171621291-be8cf39f-71e3-4e3d-a397-3e63e3dc5cf1.jpg)

Start from the build of model generator in Houdini. The dungeon map is drew by nodes as the steps shown below.
![Houdini_DrawMap](https://user-images.githubusercontent.com/67904518/171606105-f2964e45-0841-4ec2-a799-28439bbae844.png)
After the map is complete, create the wall (black block) geometry based on the map. As Houdini is a node-based software, it got the advantage of editing between nodes. And many variations can apply to the wall by changing the geometry node. Such as changing a box to a tree or building to make a difference in the look.
![Houdini_GetWall](https://user-images.githubusercontent.com/67904518/171610489-569a6aef-7b0d-48d1-92e8-dd512e77a906.png)
![Houdini_CreateWall](https://user-images.githubusercontent.com/67904518/171611218-5b03619c-fd74-49ca-8ddb-283e2a8ee99a.png)
Similar to finding the position of objects in the dungeon. Random pick points from the room group and attaches geometries to them. The geometry node can always be changed. 
![Houdini_CreatePos](https://user-images.githubusercontent.com/67904518/171622503-1fa4331d-4fdd-4274-87be-cdfcdb6ad7a5.png)
![Houdini_PosNodes](https://user-images.githubusercontent.com/67904518/171622820-bf686d41-8c53-4936-a894-6a49373f634b.jpg)

Look into the use of the dungeon generator in Unity, attributes will update to the model when changes are applied. The value can be reset to the record in HDA by clicking 'Reset All'. And the dungeon can be baked into a game object or a prefab. To replace the saved model with a new generated one, selects the original saved model under the 'Drop & drop GameObject/Prefabs' tab and click 'update'. This action will replace all components assigned to the original model. Instead of directly using the dungeon generator in the game scene, I am copying models and values from the generator to keep components on game objects getting deleted. And the upload of the dungeon will work well. The only thing needs to do after every upload is to reassign 'Mesh' under the 'Mesh Collider' component.

![Unity_HoudiniEngine](https://user-images.githubusercontent.com/67904518/171623099-be5df663-0954-4d29-9fbf-075929438b7b.jpg)

![Unity_DungeonGeo](https://user-images.githubusercontent.com/67904518/171621185-bbac763e-a280-49c8-a0d7-b9e095df969d.jpg)



After the dungeon setting up, hit 'Play' to see the result. Use 'WASD' to control the yellow ball in the dungeon. There are randomly generated enemies (red balls) in rooms. At this stage, enemies are just walking in a random direction in their rooms and without interaction with the player-controlled ball. There are furthermore to work on with the gameplay for this project.

# Reference
https://www.sidefx.com/products/houdini-engine/
https://www.sidefx.com/docs/houdini/vex/snippets.html
https://www.youtube.com/watch?v=FYT9VHY-ifA&list=WL&index=14
https://www.youtube.com/watch?v=sO-mDdJBaVI&list=WL&index=8
https://www.youtube.com/watch?v=BJzYGsMcy8Q&list=WL&index=11
https://docs.unity3d.com/Manual/index.html

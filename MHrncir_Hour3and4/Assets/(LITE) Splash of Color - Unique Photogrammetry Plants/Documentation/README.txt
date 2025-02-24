Are the materials of your project not appearing correctly? That's an easy fix, upgrade the materials from legacy materials to the pipeline you're using by navigating: Edit -> Render Pipeline -> Universal Render Pipeline or High Definition Render Pipeline -> Upgrade Project Materials.

--What prefabs do I use?--
Most users will probably want to use prefabs from either the "Medium Resolution" or the "Medium Resolution With Level Of Detail" in the prefabs folder that use atlased materials. The prefabs in the "Medium Resolution With Level Of Detail" have an LOD component that switches to a billboard and culls the prefab when too far away. Adjust the distance that the assets are swapped out with billboards and then culled by changing the "LOD Bias" setting in Project Settings -> Quality tab. LOD bias can be anywhere from 0 to infinity (including fractions.) Bigger numbers mean plants remain visible for higher distances.

--Scripts--
Billboards use a simple script (called "Billboard Script" that point them towards the vector pointing out of the main camera. Consider unchecking the "Lock Up Axis" on the billboards if you intend for the assets to be viewed from directly above. This will switch to another cheap simple billboard method where the billboard assets just point straight towards the camera.

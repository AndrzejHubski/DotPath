# DotPath
 Dynamic path build from array of dots
 
 How to use:
 1. Add script PathCreator2D/3D on object which will create path
 2. Add script PathFollower2D/3D on object whi will follow the path and write in "PositionPoint" number of point where must be the object
    (499 - head of path, where PathCreator, 0 - end of path)
 
 Simple construction if you need to make a some kind of rollercoaster or railroad. 
 But it passes only for dynamic & short path, for runners for example. 
 Because it is not best decision from point of view of performance.
 If u need a long path - better use Bezier curves

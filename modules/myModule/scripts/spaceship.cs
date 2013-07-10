function createSpaceShip()
{
   // Create the sprite.
    %spaceship = new Sprite(PlayerShip);
    
    // We want our spaceship to move and be affected by gravity and various forces
    // so we set its BodyType to dynamic
    %spaceship.setBodyType( dynamic );
       
    // Set the position at the center of our Scene
    %spaceship.Position = "0 0";

    // Set the size.        
    %spaceship.Size = "4 4";
    
    // Set the layer closest to the camera (above the background)
    %spaceship.SceneLayer = 1;
    
    // Set the scroller to use an animation!
    %spaceship.Image = "myModule:LoRez_SpaceShip";

    // This creates a box which so that collisions with the screen edges register properly
    // Calling createPolygonBoxCollisionShape() without arguments sets the box to the size of the 
    // sceneobject automatically.
    %spaceship.createPolygonBoxCollisionShape();

    // Add the sprite to the scene.
    myScene.add( %spaceship );   
   
}
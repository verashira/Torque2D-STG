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
	
	%spaceship.setCollisionCallback( true );

    // Add the sprite to the scene.
    myScene.add( %spaceship );   
   
}

function PlayerShip::onCollision(%this, %sceneobject, %collisiondetails)
{
	// If we have collided with an object belonging to Scenegroup 20,
	// execute the code between the { ... }
	// If we collide with something else, do nothing
	if (%sceneobject.getSceneGroup() == 20)
	{
		// ParticlePlayer is also derived from SceneObject, we add it just like 
		// we have added all the other so far
		%explosion = new ParticlePlayer();
		
		// We load the particle asset from our ToyAssets module
		%explosion.Particle = "ToyAssets:impactExplosion";
		
		// We set the Particle Player's position to %SceneObject's position
		%explosion.setPosition(%sceneobject.getPosition());
		
		// This Scales the particles to twice their original size
		%explosion.setSizeScale(2);
		
		// When we add a Particle Effect to the Scene, it automatically plays
		myScene.add(%explosion);
		
		// We delete the asteroid
		%sceneobject.safedelete();
		
		// We create a new asteroid just like we did at the start of the game!
		createAsteroids(1);

	}

}
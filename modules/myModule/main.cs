function MyModule::create( %this )
{
	exec("./gui/guiprofiles.cs");
	exec("./scripts/scenewindow.cs");
	exec("./scripts/scene.cs");
	
	exec("./scripts/background.cs");
	exec("./scripts/spaceship.cs");
	exec("./scripts/asteroids.cs");
	
	createSceneWindow();
	createScene();
	
	mySceneWindow.setScene(myScene);
	
	//Enable the debug visualization for "collision", "position" and "aabb"
    myScene.setDebugOn("collision", "position", "aabb");
    //Disable the debug visualization for "collision", "position" and "aabb"
    myScene.setDebugOff("collision", "position", "aabb");
	
	createBackground();
	createSpaceShip();
	createAsteroids(20);
}

function MyModule::destroy( %this )
{
	destroySceneWindow();
}
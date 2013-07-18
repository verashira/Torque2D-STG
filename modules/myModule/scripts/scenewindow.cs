function createSceneWindow()
{
	if (!isObject(mySceneWindow))
	{
		new SceneWindow(mySceneWindow);
		
		mySceneWindow.Profile = GuiDefaultProfile;
		
		Canvas.setContent(mySceneWindow);
	}
	    
	mySceneWindow.setCameraPosition( 0, 0 );
    mySceneWindow.setCameraSize( 100, 75 );
    mySceneWindow.setCameraZoom( 1 );
    mySceneWindow.setCameraAngle( 0 );
}
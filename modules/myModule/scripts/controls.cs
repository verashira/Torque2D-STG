function InputManager::onTouchDown(%this, %touchId, %worldposition)
{
	// We assign the list of objects that were hit to variable %picked
	%picked = myScene.pickPoint(%worldposition);
	
	//for (%i = 0; %i < %picked.count; %i++)
	for(%i=0; %i<%picked.count; %i++)
	{
		// When iterating through the list, getWorld will return item number %i in variable %picked
		//%myobj = getWorld(%picked, %i);
		%myobj = getWord(%picked, %i);
		
		// If this item belongs to SceneGroup 20, we delete it
		if (%myobj.getSceneGroup() == 20)
		{
			%myobj.safedelete();
		}
		
	}
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TileRenderer : MonoBehaviour {

	public Image myImage;

	private LogicTile myTile;
	
	////////////////////////////////////////
	#region MonoBehaviour Methods & Helpers

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	#endregion MonoBehaviour Methods & Helpers
	////////////////////////////////////////

	////////////////////////////////////////
	#region Getters & Setters

	public void setTile(LogicTile newTile)
	{
		renderCleanup();
		myTile = newTile;
		instantiateRendering();
		updateRender();
	}

	#endregion Getters & Setters
	////////////////////////////////////////
	
	////////////////////////////////////////
	#region Render Helpers

	// Any cleanup we might need to do if we replace existing
	private void renderCleanup(){}

	// Any object creation
	private void instantiateRendering()
	{

	}

	// Update all the values from the existing myTile setup
	private void updateRender()
	{

	}

	#endregion Render Helpers
	////////////////////////////////////////
}

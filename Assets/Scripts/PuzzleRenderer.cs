using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuzzleRenderer : MonoBehaviour {

	public GameObject tileParent;

	private LogicPuzzle myPuzzle;


	////////////////////////////////////////
	#region MonoBehaviours methods & helpers

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	#endregion MonoBehaviours methods & helpers
	////////////////////////////////////////

	////////////////////////////////////////
	#region Getters & Setters
	
	public void setPuzzle(LogicPuzzle newPuzzle)
	{
		renderCleanup();
		myPuzzle = newPuzzle;
		instantiateRendering();
		updateRender();
	}
	
	#endregion Getters & Setters
	////////////////////////////////////////

	////////////////////////////////////////
	#region Render helpers

	// Any cleanup we might need to do if we replace existing
	private void renderCleanup()
	{

	}
	
	// Any object creation
	private void instantiateRendering()
	{
		
	}
	
	// Update all the values from the existing myTile setup
	private void updateRender()
	{
		
	}

	#endregion Render helpers
	////////////////////////////////////////


}

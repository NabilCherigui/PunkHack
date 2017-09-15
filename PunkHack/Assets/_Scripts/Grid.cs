using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
	public LayerMask unWalkableMask; //unwalkable layer mask waar de speler niet kan komen.
	public Vector2 gridWorldSize; //Hoe groot de wereld is
	public float nodeRadius; //Hoe groot een node wordt
	Node[,] grid; //Waar de nodes in komen.

	float nodeDiameter = 1.0f; //Diameter van 1 node 
	int gridSizeX, gridSizeY; // X en Y waarde van het complete grid
	

	void Start()
	{
		nodeDiameter = nodeRadius * 2; // Berekening van de nodeDiameter
		gridSizeX = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter); // Berekening hoe vaak een Node in de X value past van de grid
		gridSizeY = Mathf.RoundToInt((gridWorldSize.y / nodeDiameter)); // Berekening hoe vaak een Node in de Y value past van de grid
		createGrid(); // Maak grid aan
		
	}	

	void createGrid()
	{

		Vector3 worldBottomLeft = transform.position - Vector3.right * gridWorldSize.x / 2 - Vector3.forward * gridWorldSize.y / 2;
		
		grid = new Node[gridSizeX,gridSizeY];
		for (int x = 0; x < gridSizeX; x++){
			for (int y = 0; y < gridSizeY; y++)
			{
				Vector3 worldPoint = worldBottomLeft + Vector3.right * (x * nodeDiameter + nodeRadius) +
				Vector3.forward * (y * nodeDiameter + nodeRadius);
				bool walkable = !(Physics.CheckSphere(worldPoint, nodeRadius,unWalkableMask));
				grid[x,y] = new Node(walkable,worldPoint);
				

			}
		}
		
	}
	
	private void OnDrawGizmos()
	{
	
		Gizmos.DrawWireCube(transform.position,new Vector3(gridWorldSize.x,1,gridWorldSize.y)); // y axis declareert de z axis in 3d wereld
		if (grid != null)
		{
				
				foreach (Node n in grid){
					Gizmos.color = (n.walkable) ? Color.white : Color.red;
					Gizmos.DrawCube(n.worldPosition, Vector3.one * (nodeDiameter-.1f));
				}
			
		}
	}
	public class Node {
	
		public bool walkable;
		public Vector3 worldPosition;
	
		public Node(bool _walkable, Vector3 _worldPos) {
			walkable = _walkable;
			worldPosition = _worldPos;
		}
}

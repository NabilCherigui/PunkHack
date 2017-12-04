using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	[SerializeField] private Vector2 _target;
	[SerializeField] private float _speed;
	[SerializeField] private bool _go;

	private void Update()
	{
		if (_go)
		{
			transform.position = Vector2.MoveTowards(transform.position, _target, _speed);
		}
	}
}

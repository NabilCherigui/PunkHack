using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{
	[SerializeField] private GameObject[] _people;
	[SerializeField] private string[] _device;
	[SerializeField] private string[] _activity;
	[SerializeField] private string[] _sentiment;
	[SerializeField] private string[] _issue;
	[SerializeField] private string[] _faction;

	public string[] Device { get {return _device;}}
	public string[] Activity { get {return _activity;}}
	public string[] Sentiment { get {return _sentiment;}}
	public string[] Issue { get {return _issue;}}
	public string[] Faction { get {return _faction;}}
	
}

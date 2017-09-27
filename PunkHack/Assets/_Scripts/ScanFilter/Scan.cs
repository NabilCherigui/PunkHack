using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{
	[SerializeField] private Label[] _people;
	[SerializeField] private string[] _categories;
	[SerializeField] private string[] _device;
	[SerializeField] private string[] _activity;
	[SerializeField] private string[] _sentiment;
	[SerializeField] private string[] _issue;
	[SerializeField] private string[] _faction;
	[SerializeField] private Sprite _sprite;
	
	[SerializeField] private List<string> _selected = new List<string>();
	[SerializeField] private List<Label> _peopleSelected = new List<Label>();
	
	public string[] Device { get {return _device;}}
	public string[] Activity { get {return _activity;}}
	public string[] Sentiment { get {return _sentiment;}}
	public string[] Issue { get {return _issue;}}
	public string[] Faction { get {return _faction;}}

    private void Awake()
    {
        _people = FindObjectsOfType(typeof(Label)) as Label[];
    }
    
    private void Update()
    {
	 /*   if (Input.GetKeyDown(KeyCode.Space))
	    {
		    for (int i = 0; i < _people.Length; i++)
		    {
			    {
				    for (int j = 0; j < _selected.Count; j++)
				    {
					    if (_people[i]._device == _selected[j])
					    {
						    print(_people[i]);
					    }
					    else if (_people[i]._activity == _selected[j])
					    {
						    print(_people[i]);
					    }
					    else if (_people[i]._sentiment == _selected[j])
					    {
						    print(_people[i]);
					    }
					    else if (_people[i]._issue == _selected[j])
					    {
						    print(_people[i]);
					    }
					    else if (_people[i]._faction == _selected[j])
					    {
						    print(_people[i]);
					    }
				    }
			    }
		    }
	    }*/
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
		      
		    Search(_selected.ToArray());
	    }
	    
    }

	public void Search(string[] condition)
	{
		_peopleSelected.Clear();
		for (int i = 0; i < _people.Length; i++)
		{
			var people = _people[i];
			var correct = 0;
			for (int j = 0; j < 5; j++)
			{
				for (int k = 0; k < condition.Length; k++)
				{
					if (people.Labels[j] == condition[k])
					{
						correct++;

						if (condition.Length == correct)
						{
							_peopleSelected.Add(people);
							people.GetComponent<SpriteRenderer>().sprite = _sprite;
							people.GetComponent<SpriteRenderer>().enabled = true;

						}
					}	
				}
			}
		}
	}
	
}

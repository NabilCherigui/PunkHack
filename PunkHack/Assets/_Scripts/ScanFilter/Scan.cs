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
	
	public string[] Device { get {return _device;}}
	public string[] Activity { get {return _activity;}}
	public string[] Sentiment { get {return _sentiment;}}
	public string[] Issue { get {return _issue;}}
	public string[] Faction { get {return _faction;}}

    private int _selected;

    private void Awake()
    {
        _people = FindObjectsOfType(typeof(Label)) as Label[];
    }
    
    private void Update()
    {
//        if (Input.GetKeyDown(KeyCode.Alpha1))
//        {
//            if (_selected != 0)
//            {
//                print("no work");
//                return;
//            }
//	        _selected = 1;
//        }
//        else if (Input.GetKeyDown(KeyCode.Alpha2))
//        {
//            if (_selected != 0)
//            {
//                print("no work");
//                return;
//            }
//            _selected = 2;
//        }
//        else if (Input.GetKeyDown(KeyCode.Escape))
//        {
//            _selected = 0;
//        }

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
		    for (int i = 0; i < _categories.Length; i++)
		    {
			    print(_categories[i]);
		    }
	    }
	    
	    if (Input.GetKeyDown(KeyCode.Alpha1) && _selected == 0)
	    {
		    for (int i = 0; i < _device.Length; i++)
		    {
			    print(_device[i]);
		    }
		    _selected = 1;
	    }
	    else if(Input.GetKeyDown(KeyCode.Alpha1) && _selected == 1)
	    {
		    for (int i = 0; i < _people.Length; i++)
		    {
			    if (_people[i]._device == "D.1")
			    {
				    print(_people[i]);
			    }
		    }
			    
	    }
	    
	    
	    
        print(_selected);

//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            for (int i = 0; i < _people.Length; i++)
//            {
//                if (_people[i]._issue == "I.2")
//                {
//                    print(_people[i]);
//                }
//            }
//        }
    }
}

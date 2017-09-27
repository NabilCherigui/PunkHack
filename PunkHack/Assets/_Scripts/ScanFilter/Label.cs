using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label : MonoBehaviour
{
    [SerializeField] private Scan _scan;
    [SerializeField] public string _device;
    [SerializeField] public string _activity;
    [SerializeField] public string _sentiment;
    [SerializeField] public string _issue;
    [SerializeField] public string _faction;
    
    [SerializeField] private List<string> _labels = new List<string>();
    
    [SerializeField] public List<string> Labels {get { return _labels; }}
    
    private void Start()
    {
        _device = _scan.Device[Random.Range(0,2)];
        _activity = _scan.Activity[Random.Range(0,2)];
        _sentiment = _scan.Sentiment[Random.Range(0,2)];
        _issue = _scan.Issue[Random.Range(0,2)];
        _faction = _scan.Faction[Random.Range(0,2)];
        
        _labels.Add(_scan.Device[Random.Range(0,2)]);
        _labels.Add(_scan.Activity[Random.Range(0,2)]);
        _labels.Add(_scan.Sentiment[Random.Range(0,2)]);
        _labels.Add(_scan.Issue[Random.Range(0,2)]);
        _labels.Add(_scan.Faction[Random.Range(0,2)]);
    }
    
}

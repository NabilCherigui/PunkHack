using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label : MonoBehaviour
{
    [SerializeField] private Scan _scan;
    [SerializeField] private string _device;
    [SerializeField] private string _activity;
    [SerializeField] private string _sentiment;
    [SerializeField] private string _issue;
    [SerializeField] private string _faction;

    private void Start()
    {
        _device = _scan.Device[Random.Range(0,2)];
        _activity = _scan.Activity[Random.Range(0,2)];
        _sentiment = _scan.Sentiment[Random.Range(0,2)];
        _issue = _scan.Issue[Random.Range(0,2)];
        _faction = _scan.Faction[Random.Range(0,2)];
        
    }
}

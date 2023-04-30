using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGeneration : MonoBehaviour
{
    [SerializeField]
    private RoadPrefab _firstRoad;
    [SerializeField]
    private RoadPrefab[] _roadPrefabs;

    [SerializeField]
    private int _length;

    private List<RoadPrefab> _spawnedRoads = new List<RoadPrefab>();
    private float _direction = 0f;

    private void Start()
    {
        _spawnedRoads.Add(_firstRoad);
        for(int i =0; i< _length; i++)
        {
            SpawnRoad();
        }
    }

    private void SpawnRoad()
    {
        RoadPrefab newRoad = Instantiate(_roadPrefabs[Random.Range(0, _roadPrefabs.Length)]);
        _direction += newRoad.Rotation;
        newRoad.transform.Rotate(0, _direction, 0);
        var diferentPoss = newRoad.transform.position - newRoad.BeginPoint.position;
        newRoad.BeginPoint.localPosition = _spawnedRoads[_spawnedRoads.Count - 1].EndPoint.position;
        newRoad.transform.position = diferentPoss + newRoad.BeginPoint.localPosition;



        //newRoad.transform.position = _spawnedRoads[_spawnedRoads.Count - 1].EndPoint.position - newRoad.BeginPoint.localPosition;

        _spawnedRoads.Add(newRoad);
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 50, 50), "Spawn"))
        {
            SpawnRoad();
        }
    }
}

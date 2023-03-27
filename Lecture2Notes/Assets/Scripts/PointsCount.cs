using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCount : MonoBehaviour, IDataPersistence
{
    uint RoundPointsCount = 0;
    uint GamePointsCount = 0;
    uint CareerPointsCount = 0;
    uint attemtPoints = 0;
    [SerializeField] GameObject[] points;
    [SerializeField] GameObject car;
    [SerializeField] GameObject ramp;
    void Start()
    {
        car = GameObject.FindGameObjectWithTag("car");
        ramp = GameObject.FindGameObjectWithTag("Ramp");
        points = GameObject.FindGameObjectsWithTag("Point");
    }

    public void LoadData(GameData data)
    {
        this.CareerPointsCount = data.CareerPointsCount;
    }
    public void SaveData(ref GameData data)
    {
        data.CareerPointsCount = this.CareerPointsCount;
    }
    void Update()
    {
        
    }
}

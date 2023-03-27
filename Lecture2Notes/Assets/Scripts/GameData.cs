using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public uint RoundDeathCount;
    public uint GameDeathCount;
    public uint CareerDeathCount;
    public uint RoundPointsCount;
    public uint GamePointsCount;
    public uint CareerPointsCount;
    public uint CurrentAttempt;

    //the values in the constructor will be the intitial starting values
    //the game starts with these values when there are no values to load
    public GameData()
    {
        this.RoundDeathCount = 0;
        this.GameDeathCount = 0;
        this.CareerDeathCount = 0;
        this.RoundPointsCount = 0;
        this.GamePointsCount = 0;
        this.CareerPointsCount = 0;
        this.CurrentAttempt = 1;
    }
}

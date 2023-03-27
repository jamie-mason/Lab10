using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeathCount : MonoBehaviour, IDataPersistence
{
    //I have not set the script to define a round or a whole game so it will just save all the death counts the same.
    //My intent is to show the player how many times they died at the end of each round along with how many points they got.
    //Also I will show them their total of all the rounds at the end of a game which will consist of an undecided number of rounds.
    //The career death count will be accessed in a menu area where they can see their total stats consisting of the sum of total deaths form every game the player has played.
    uint RoundDeathCount = 0;
    uint GameDeathCount = 0;
    uint CareerDeathCount = 0;
    bool hasDied = false;
    [SerializeField]GameObject[] points;
    [SerializeField] GameObject car;
    [SerializeField] GameObject ramp;
    [SerializeField] float distanceBelowLowest = 10f;
    [SerializeField] float distanceAboveHighest = 100f;
    private void Start()
    {
        car = GameObject.FindGameObjectWithTag("car");
        ramp = GameObject.FindGameObjectWithTag("Ramp");
        points = GameObject.FindGameObjectsWithTag("Point");
        getLowestPointObjectY();
    }
    float getLowestPointObjectY()
    {
        float lowestY = float.MaxValue;
        float thisY;
        for(int i = 0; i < points.Length; i++)
        {
            thisY = points[i].transform.position.y - points[i].transform.lossyScale.y;
            if(thisY < lowestY)
            {
                lowestY = thisY;
            }
        }
        return lowestY;
    }
    float getHighestPoint()
    {
        return ramp.transform.position.y + ramp.transform.lossyScale.y;
    }
    public void LoadData(GameData data)
    {
        this.CareerDeathCount = data.CareerDeathCount;
    }
    public void SaveData(ref GameData data)
    {
        data.CareerDeathCount = this.CareerDeathCount;
    }
    void setDead()
    {
        hasDied = true;
        Debug.Log("I died");
        RoundDeathCount++;
        GameDeathCount++;
        CareerDeathCount++;
    }
    void Die()
    {
        if (getLowestPointObjectY() - distanceBelowLowest >= car.transform.position.y + car.transform.lossyScale.y)
        {
            setDead();
        }
        if (getHighestPoint() + distanceAboveHighest <= car.transform.position.y + car.transform.lossyScale.y)
        {
            setDead();
        }
    }
    
    void Update()
    {
        if (!hasDied)
        {
            Die();
        }
    }
}

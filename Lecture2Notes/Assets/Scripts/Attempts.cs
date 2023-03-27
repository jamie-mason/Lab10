using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Attempts : MonoBehaviour, IDataPersistence
{
    public uint NumberOfAttemptsInRound = 4;
    uint CurrentAttempt = 1;
    TextMeshProUGUI attempts;

    void Start()
    {
        attempts = GameObject.Find("attemptInRound").GetComponent<TextMeshProUGUI>();
    }
    public void LoadData(GameData data)
    {
        this.CurrentAttempt = data.CurrentAttempt;
    }
    public void SaveData(ref GameData data)
    {
        data.CurrentAttempt = this.CurrentAttempt;
    }
    void Update()
    {
        attempts.text = CurrentAttempt + "/" + NumberOfAttemptsInRound;
    }
    public uint getCurrentAttempt()
    {
        return CurrentAttempt;
    }
    public void setCurrentAttempt(uint currentAttempt)
    {
        this.CurrentAttempt = currentAttempt;
    }
}

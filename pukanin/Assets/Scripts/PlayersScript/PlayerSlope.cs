using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlope : MonoBehaviour {

    [SerializeField] private float initialSlope;
    [SerializeField] private float recoveryRate;
    [SerializeField] private float stunTime;

    private float currentSlope;
    //private float currentStunTime;
    //private bool isStunned;
    private Dictionary<float, string> playerState = 
        new Dictionary<float, string>();

    // Use this for initialization
    void Start() {
        currentSlope = initialSlope;
        //currentStunTime = 0;

        playerState.Add(90, "Normal");
        playerState.Add(60, "Slanted");
        playerState.Add(30, "Falling");
        playerState.Add(0, "Down");
    }

    // Update is called once per frame
    void Update() {
        if (currentSlope == initialSlope) return;

        //if(isStunned)
        //{
        //    currentStunTime += Time.deltaTime;
        //    if (currentStunTime >= stunTime) currentStunTime = 0;
        //    if (currentStunTime == 0) isStunned = false;

        //    return;
        //}

        if (currentSlope <= 0) currentSlope = 0;

        if (currentSlope <= initialSlope)
            currentSlope += Time.deltaTime * recoveryRate;
        else
            currentSlope = initialSlope;
    }

    public void Damaged(int value) {
        //if (isStunned) return;

        currentSlope -= value;
        //isStunned = true;
    }

    public float CurrentSlope
    {
        get { return currentSlope; }
    }

    public string CurrentState()
    {
        foreach(var stateDict in playerState)
        {
            if (currentSlope >= stateDict.Key)
                return stateDict.Value;
        }

        return "";
    }

    //public bool IsStunned
    //{
    //    get { return isStunned; }
    //}
}

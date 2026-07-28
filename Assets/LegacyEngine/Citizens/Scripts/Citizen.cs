using UnityEngine;

public class Citizen : MonoBehaviour
{
    public string citizenName = "John";

    private void Start()
    {
        Debug.Log(citizenName + " has entered the town.");
    }
}
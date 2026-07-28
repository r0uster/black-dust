using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public int day = 1;
    public int hour = 8;

    public float secondsPerHour = 75f;

    private float timer = 0f;

    private void Start()
    {
        Debug.Log("Day: " + day);
        Debug.Log("Hour: " + hour);
        Debug.Log("The town is waking up.");
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= secondsPerHour)
        {
            timer = 0f;
            hour++;

            if (hour >= 24)
            {
                hour = 0;
                day++;
            }

            Debug.Log("Day: " + day + " Hour: " + hour);
        }
    }
}
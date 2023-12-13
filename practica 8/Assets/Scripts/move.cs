using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float orientation = 0.0f;
    float longitude = 0.0f;
    float latitude = 0.0f;
    float velocity = 30.0f;
    float[] latitudesLimits = { -20.0f, -10.0f };
    float[] longitudesLimits = { 25.0f, 35.0f };
    Vector2 actualPosition = new Vector2(0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
        Input.gyro.enabled = true; 
        Input.compass.enabled = true;       
    }

    // Update is called once per frame
    void Update()
    {
        longitude = Input.location.lastData.longitude;
        latitude = Input.location.lastData.latitude;
        
        // round the values to 2 decimals
        longitude = Mathf.Round(longitude * 100f) / 100f;
        latitude = Mathf.Round(latitude * 100f) / 100f;

        actualPosition.x = longitude;
        actualPosition.y = latitude;
        
        orientation = Input.compass.trueHeading;
        transform.rotation = Quaternion.Euler(0, 180 + (360 - orientation), 0);

        float acelerationX = -Input.gyro.attitude.x;
        
        Vector3 movement = new Vector3(0.0f, 0.0f, acelerationX);

        transform.Translate(movement * velocity * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class data : MonoBehaviour
{
    float orientation = 0.0f;
    float angularVelocity = 0.0f;
    float aceleration = 0.0f;
    float altitude = 0.0f;
    float gravity = 0.0f;
    float longitude = 0.0f;
    float latitude = 0.0f;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();

    }

    // Update is called once per frame
    void Update()
    {
        // Crear una aplicación en Unity que muestre en la UI los valores de:  Velocidad angular, Aceleración, Altitud y gravedad, Longitud y Latitud.
        Input.gyro.enabled = true;
        Input.compass.enabled = true;
        orientation = Input.compass.trueHeading;
        angularVelocity = Input.gyro.rotationRateUnbiased.magnitude;
        aceleration = Input.gyro.userAcceleration.magnitude;
        gravity = Input.gyro.gravity.magnitude;
        altitude = Input.location.lastData.altitude;
        longitude = Input.location.lastData.longitude;
        latitude = Input.location.lastData.latitude;

        // round the values to 2 decimals
        angularVelocity = Mathf.Round(angularVelocity * 100f) / 100f;
        aceleration = Mathf.Round(aceleration * 100f) / 100f;
        altitude = Mathf.Round(altitude * 100f) / 100f;
        gravity = Mathf.Round(gravity * 100f) / 100f;
        longitude = Mathf.Round(longitude * 100f) / 100f;
        latitude = Mathf.Round(latitude * 100f) / 100f;


        // Create a chain with the data
        text.text = "Angular Velocity: " + angularVelocity + "\n" + "Aceleration: " + aceleration + "\n" + "Altitude: " + altitude + "\n" + "Gravity: " + gravity + "\n" + "Longitude: " + longitude + "\n" + "Latitude: " + latitude + "\n" + " Status: " + Input.location.status + "\n" + "Orientation: " + orientation;
    }   
}

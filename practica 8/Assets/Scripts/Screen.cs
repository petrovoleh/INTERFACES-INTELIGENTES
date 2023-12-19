using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{   
    private Material tvMaterial;
    public string path;
    private WebCamTexture webcamTexture;
    private int CaptureCounter = 1;
    private bool activeCam;
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        tvMaterial = GetComponent<Renderer>().material;
        path = "C:\\Github\\INTERFACES-INTELIGENTES\\practica 8\\";
        activeCam = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey("s")) { // Active cam
        if (!activeCam)
          activeCam = true;
          tvMaterial.mainTexture = webcamTexture;
          webcamTexture.Play();
       }

       if (Input.GetKey("p")) { //Pause cam
         if (activeCam)
          activeCam = false;
          webcamTexture.Stop();
       }

       if (Input.GetKey("x")) { // Take screen
            if (activeCam) {
                Texture2D snap = new Texture2D(webcamTexture.width, webcamTexture.height);
                snap.SetPixels(webcamTexture.GetPixels());
                snap.Apply();
                System.IO.File.WriteAllBytes(path + CaptureCounter.ToString() + ".png", snap.EncodeToPNG());
                ++CaptureCounter;
                Debug.Log(path + CaptureCounter.ToString());
            } 
       }
       
    }
}

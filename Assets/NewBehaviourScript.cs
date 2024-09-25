using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.Experimental.Lightship.AR.WorldPositioning;

public class WPSCompass : MonoBehaviour
{
    [SerializeField] private ARCameraManager _arCameraManager;
    
    private ARWorldPositioningCameraHelper _WPSCameraHelper;

    // Start is called before the first frame update
    void Start()
    {
      _WPSCameraHelper = _arCameraManager.GetComponent<ARWorldPositioningCameraHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        float heading = _WPSCameraHelper.TrueHeading;
        Quaternion rotation = Quaternion.Euler(0, 0, heading);
        
        double latitute = _WPSCameraHelper.Latitude;
        double longitude = _WPSCameraHelper.Longitude;
    }
}
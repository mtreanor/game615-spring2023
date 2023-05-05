using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CylinderScript : MonoBehaviour
{
    Vignette vignette;
    public PostProcessVolume ppv;
    bool zoom = false;
    // Start is called before the first frame update
    void Start()
    {
        ppv.profile.TryGetSettings(out vignette);
    }

    // Update is called once per frame
    void Update()
    {
        if (zoom)
        {
            vignette.intensity.value = vignette.intensity + 0.1f * Time.deltaTime;
        }
    }

    public void StartZoom()
    {
        vignette.intensity.value = 0;
        StartCoroutine(PrintSomethingInHalfASecond());
        zoom = true;
        
    }

    public void StopZoom()
    {
        zoom = false;
    }

    IEnumerator PrintSomethingInHalfASecond()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("Something");
    }
}

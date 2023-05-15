using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SoulLight : MonoBehaviour
{
    public Light lightPoint;
    async void Start()
    {
        float targetIntensity = 500f;
        float duration = 5f; 
        float startTime = Time.time;

        while (lightPoint.intensity < targetIntensity)
        {
            float elapsedTime = Time.time - startTime;
            float progress = elapsedTime / duration;
            float currentIntensity = Mathf.Lerp(0f, targetIntensity, progress);

            lightPoint.intensity = currentIntensity;

            await Task.Delay(10); 
        }
    }

   
}

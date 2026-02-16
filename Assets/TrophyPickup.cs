using UnityEngine;
using UnityEngine.Video;

public class TrophyPickup : MonoBehaviour
{
    public GameObject trophyObject;
    public Material fireworksSkybox;
    public VideoPlayer skyVideo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == trophyObject)
        {
            // Vaihdetaan taivas ilotulituksiin
            RenderSettings.skybox = fireworksSkybox;
            DynamicGI.UpdateEnvironment();

            // Käynnistä 360-videon toisto
            if (skyVideo != null)
                skyVideo.Play();
        }
    }
}

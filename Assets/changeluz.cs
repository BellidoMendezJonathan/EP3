using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;



public class ChangeLight : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float minDistance = 1f;
    [SerializeField] private Light2D lightSource; // The Light2D component
    [SerializeField] private float duration = 45.0f; // Duration to reach the target intensity
    [SerializeField] private float targetIntensity = 0.15f; // Target intensity value
    private float initialIntensity; // Store the initial intensity
    private bool isDimming = false; // To prevent starting multiple coroutines

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light2D>(); // Get the Light2D component if not assigned
        }
        initialIntensity = lightSource.intensity; // Store the initial intensity
    }

    void Update()
    {
        float sqrDistance = (player.transform.position - transform.position).sqrMagnitude;
        float sqrMinDistance = minDistance * minDistance;

        if (sqrDistance < sqrMinDistance && !isDimming)
        {
            StartCoroutine(DecreaseLightIntensity());
        }
    }

    private IEnumerator DecreaseLightIntensity()
    {
        isDimming = true;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            lightSource.intensity = Mathf.Lerp(initialIntensity, targetIntensity, elapsedTime / duration);
            yield return null;
        }

        lightSource.intensity = targetIntensity;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, minDistance);
    }
}

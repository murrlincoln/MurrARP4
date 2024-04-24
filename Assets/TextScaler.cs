using UnityEngine;

public class TextScaler : MonoBehaviour
{
    public float scaleTime = 1.0f;
    private Vector3 originalScale;
    private bool isScaling = false;

    void Start()
    {
        originalScale = transform.localScale;
        transform.localScale = Vector3.zero;  // Start scaled down to zero
    }

    public void ScaleUp()
    {
        if (!isScaling)
        {
            StartCoroutine(ScaleAnimation());
        }
    }

    System.Collections.IEnumerator ScaleAnimation()
    {
        isScaling = true;
        float currentTime = 0.0f;

        while (currentTime < scaleTime)
        {
            currentTime += Time.deltaTime;
            transform.localScale = Vector3.Lerp(Vector3.zero, originalScale, currentTime / scaleTime);
            yield return null;
        }

        transform.localScale = originalScale;
        isScaling = false;
    }
}

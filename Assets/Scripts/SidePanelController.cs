using UnityEngine;
using System.Collections;

public class SidePanelController : MonoBehaviour
{
    public RectTransform panel;
    public float animationDuration = 0.3f; // Time in seconds

    private bool open = false;
    private Coroutine moveCoroutine;

    void Start()
    {
        panel.anchoredPosition = new Vector2(500, 0);
    }

    public void TogglePanel()
    {
        open = !open;
        Vector2 targetPosition = open ? new Vector2(0, 0) : new Vector2(500, 0);


        if (moveCoroutine != null)
            StopCoroutine(moveCoroutine);


        moveCoroutine = StartCoroutine(SmoothMove(targetPosition));
    }

    public void ClosePanel()
    {
        if (open)
            TogglePanel();
    }

    public void OnOverlayClicked()
    {
        ClosePanel();
    }

    private IEnumerator SmoothMove(Vector2 target)
    {
        Vector2 startPosition = panel.anchoredPosition;
        float elapsedTime = 0f;

        while (elapsedTime < animationDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / animationDuration;
            

            float smoothT = Mathf.SmoothStep(0f, 1f, t); 

            panel.anchoredPosition = Vector2.Lerp(startPosition, target, smoothT);
            yield return null;
        }

        panel.anchoredPosition = target;
    }
}

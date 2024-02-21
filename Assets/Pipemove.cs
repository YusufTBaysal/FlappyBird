using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float scrollSpeed = 1.0f;

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
    }

}

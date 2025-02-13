using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 4f;
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

}

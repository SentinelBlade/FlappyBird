using UnityEngine;

public class Parrallax : MonoBehaviour
{
    private MeshRenderer mRenderer;
    public float animationspeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        mRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mRenderer.material.mainTextureOffset += new Vector2(animationspeed * Time.deltaTime, 0);
    }
}

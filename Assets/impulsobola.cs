using UnityEngine;

public class ImpulsoBola : MonoBehaviour
{
    public float forcaX = 0f;
    public float forcaZ = -2f; // Experimenta valores positivos ou negativos

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Substitui rb.linearVelocity por rb.velocity se usares uma versão antiga do Unity
            rb.linearVelocity = new Vector3(forcaX, rb.linearVelocity.y, forcaZ);
        }
    }
}
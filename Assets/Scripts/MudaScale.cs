using UnityEngine;

public class MudaScale : MonoBehaviour
{
    public GameObject otherGameObject;
    private float direction = -1;
    private float originalXScale;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mudaPosition(gameObject);
            mudaPosition(otherGameObject);
        }
    }

    private void mudaPosition(GameObject gameObject)
    {
        originalXScale = gameObject.transform.localScale.x;
        
        Vector3 scale = transform.localScale;
        scale.x = originalXScale*direction;
        gameObject.transform.localScale = scale;
    }
}

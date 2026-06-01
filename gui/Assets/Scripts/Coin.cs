using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerOM.CollectCoin(1);

            Destroy(gameObject);
        }
    }
}

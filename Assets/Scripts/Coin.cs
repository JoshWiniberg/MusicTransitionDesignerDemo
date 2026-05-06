using UnityEngine;

namespace MtdDemo
{
    public class Coin : MonoBehaviour
    {
        private CoinGroup coinGroup;
        private AudioSource audioSource;

        private void Awake()
        {
            coinGroup = gameObject.GetComponentInParent<CoinGroup>();
            audioSource = gameObject.GetComponent<AudioSource>();

            if (coinGroup != null && audioSource != null)
                return;
            else
            {
                enabled = false;
                return;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && audioSource != null)
            {
                coinGroup.PlayCoinSound(this);
            }
        }
    }
}

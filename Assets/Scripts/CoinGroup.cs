using MusicTransitionDesigner.Samples;
using UnityEngine;

namespace MtdDemo
{
    public class CoinGroup : MonoBehaviour
    {
        public MtdDemoQueueUntilBeat queueUntilBeat;
        public double offset = -0.1;

        public void PlayCoinSound(Coin coin)
        {
            AudioSource audioSource = coin.GetComponent<AudioSource>();

            queueUntilBeat.QueueCommand(
                        tag: "Coin",
                        action: (time) => audioSource.PlayScheduled(time + offset)
                    );
        }
    }
}

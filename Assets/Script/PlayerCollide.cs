using UnityEngine;
using UnityEngine.Events;

public class PlayerCollider : MonoBehaviour
{
   [SerializeField]
  private string obstacleTag = "Obstacle";
  [SerializeField]
  private string coinTag = "Coin";
  [SerializeField]
  private UnityEvent<Transform> onObstacleCollision;
  [SerializeField]
  private UnityEvent<Transform> onCoinCollited;
  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(obstacleTag))
        {
            onObstacleCollision?.Invoke(transform);
        }
        else if (other.CompareTag(coinTag))
        {
            onCoinCollited?.Invoke(transform);
            other.gameObject.SetActive(false);
        }
    }
}

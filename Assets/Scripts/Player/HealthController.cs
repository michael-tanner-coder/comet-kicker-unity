using UnityEngine;
using ScriptableObjectArchitecture;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private IntVariable _health;

    [SerializeField]
    private GameEvent _gameOverEvent;

    public void Damage()
    {
        _health.Value -= 1;

        if (_health.Value < 0)
        {
            // call game over event
            _gameOverEvent?.Raise();
        }
    }

    public void Heal()
    {
        _health.Value += 1;
    }
}

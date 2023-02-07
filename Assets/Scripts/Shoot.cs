using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Vector2Variable _aimDirection;

    [SerializeField]
    private ProjectileSO _projectileType;

    [SerializeField]
    private GameObject _projectile;

    [SerializeField]
    private PlayerInput _input;

    [SerializeField]
    private float _shotDelay = 2f;
    private bool _didShoot = false; 

    void Update()
    {
        if (_input.actions["shoot"].triggered && !_didShoot)
        {
            SpawnProjectile();
            _didShoot = true;
        }

        if (_didShoot)
        {
            _shotDelay -= Time.deltaTime;
        }

        if (_shotDelay <= 0)
        {
            _didShoot = false;
            _shotDelay = 2f;
        }
    }

    void SpawnProjectile()
    {
        GameObject _newProjectile = Instantiate(_projectile, transform.position, Quaternion.identity);
        _newProjectile.GetComponent<MoveInOwnDirection>().SetDirection(_aimDirection.Value * _projectileType.Speed);
    }
}

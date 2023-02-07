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

    void Update()
    {
        if (_input.actions["shoot"].triggered)
        {
            SpawnProjectile();
        }
    }

    void SpawnProjectile()
    {
        GameObject _newProjectile = Instantiate(_projectile, transform.position, Quaternion.identity);
        _newProjectile.GetComponent<MoveInOwnDirection>().SetDirection(_aimDirection.Value * _projectileType.Speed);
    }
}

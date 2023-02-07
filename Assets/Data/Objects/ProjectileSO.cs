using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileSO", menuName = "comet-kicker-unity/ProjectileSO", order = 0)]
public class ProjectileSO : ScriptableObject {
    [SerializeField]
    private float _speed = 1f;
    public float Speed => _speed;
    
    [SerializeField]
    private int _count = 1;
    public int Count => _count;

    [SerializeField]
    private Sprite _sprite;
    private Sprite Sprite => _sprite;
}

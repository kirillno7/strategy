using UnityEngine;


    public class MainBuilding : MonoBehaviour, ISelecatable
{
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
    public Transform PivotPoint => _pivotPoint;

        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;
         [SerializeField] private Transform _pivotPoint;
          private float _health = 1000;


   
}

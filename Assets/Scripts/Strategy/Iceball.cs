using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Iceball", menuName = "Spells/Iceball")]
public class Iceball : Spell
{
    [SerializeField]
    private GameObject prefab;
    public override GameObject Prefab => prefab;

    public override void Cast(Transform transform)
    {
        var spell = new IceballBuilder()
            .SetPrefab(Prefab)
            .SetSpeed(15)
            .SetDamage(15)
            .Build(transform);
    }

    class IceballBuilder : ISpellBuilder
    {
        private GameObject _spellPrefab;
        private float _speed;
        private float _damage;
        private float _destroyTime;

        public ISpellBuilder SetPrefab(GameObject prefab)
        {
            _spellPrefab = prefab;
            return this;
        }

        public ISpellBuilder SetSpeed(float speed)
        {
            _speed = speed;
            return this;
        }

        public ISpellBuilder SetDamage(float damage)
        {
            _damage = damage;
            return this;
        }

        public ISpellBuilder SetDestroyTime(float destroyTime)
        {
            _destroyTime = destroyTime;
            return this;
        }

        public GameObject Build(Transform transform)
        {
            Vector3 instantiatePosition = transform.position + transform.forward * 2;

            GameObject spell = GameObject.Instantiate(_spellPrefab, instantiatePosition, transform.rotation);
            spell.GetComponent<Rigidbody>().velocity = transform.forward * _speed;

            return spell;
        }
    }
}

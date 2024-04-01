using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Fireball", menuName = "Spells/Fireball")]
public class Fireball : Spell
{
    [SerializeField]
    private GameObject prefab;
    public override GameObject Prefab => prefab;

    public override void Cast(Transform transform)
    {
        var spell = new FireballBuilder()
            .SetPrefab(Prefab)
            .SetSpeed(10)
            .SetDamage(10)
            
            .Build(transform);
    }

    class FireballBuilder : ISpellBuilder
    {
        private GameObject _spellPrefab;
        private float _speed;
        private float _damage;

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

        public GameObject Build(Transform transform)
        {
            Vector3 instantiatePosition = transform.position + transform.forward * 2;

            GameObject spell = GameObject.Instantiate(_spellPrefab, instantiatePosition, transform.rotation);
            spell.GetComponent<Rigidbody>().velocity = transform.forward * _speed;

            return spell;
        }
    }
}

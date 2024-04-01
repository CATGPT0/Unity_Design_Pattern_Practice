using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Black Hole", menuName = "Spells/Black Hole")]
public class BlackHole : Spell
{
    [SerializeField]
    private GameObject prefab;
    public override GameObject Prefab => prefab;

    public override void Cast(Transform transform)
    {
        var spell = new BlackholeBuilder()
            .SetPrefab(Prefab)
            .SetSpeed(5)
            .SetDamage(20)
            .SetDestroyTime(5)
            .Build(transform);
    }

    class BlackholeBuilder : ISpellBuilder
    {
        private GameObject _spellPrefab;
        private GameObject _spell;
        private float _speed;
        private float _damage;
        private float _destroyTime;

        public ISpellBuilder SetPrefab(GameObject prefab)
        {
            _spellPrefab = prefab;
            _spell = GameObject.Instantiate(_spellPrefab);
            return this;
        }

        public ISpellBuilder SetSpeed(float speed)
        {
            _speed = speed;
            _spell.AddComponent<BlackholeMove>().Speed = _speed;
            return this;
        }

        public ISpellBuilder SetDamage(float damage)
        {
            _damage = damage;
            _spell.AddComponent<BlackholeAttack>().AttackDamage = _damage;
            return this;
        }

        public ISpellBuilder SetDestroyTime(float destroyTime)
        {
            _destroyTime = destroyTime;
            _spell.AddComponent<BlackholeDestroy>().DestroyTime = _destroyTime;
            return this;
        }

        public GameObject Build(Transform transform)
        {
            Vector3 instantiatePosition = transform.position + transform.forward * 2;
            _spell.transform.position = instantiatePosition;
            return _spell;
        }
    }
}

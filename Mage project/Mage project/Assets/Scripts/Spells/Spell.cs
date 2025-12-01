using UnityEngine;



[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Spell : MonoBehaviour
{

    public SpellScriptableObject SpellToCast;


    private SphereCollider mycollider;
    private Rigidbody myrigidbody;


    private void Awake()
    {
        mycollider = GetComponent<SphereCollider>();
        myrigidbody = GetComponent<Rigidbody>();
        mycollider.isTrigger = true;
        mycollider.radius = SpellToCast.spellRadius;
        myrigidbody.isKinematic = true;

        Destroy(this.gameObject, SpellToCast.lifetime);

    }

    private void Update()
    {
        if (SpellToCast.speed > 0) transform.Translate(Vector3.forward * SpellToCast.speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            HealthComponent enemyHealth = other.GetComponent<HealthComponent>();
            enemyHealth.TakeDamage(SpellToCast.damageAmount);
        }


        Destroy(this.gameObject);
    }
}




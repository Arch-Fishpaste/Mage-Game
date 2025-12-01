using UnityEngine;

public class PlayerMagicSystem : MonoBehaviour
{

    [SerializeField]private Spell spellToCast;

    [SerializeField] private float maxMana = 100f;
    [SerializeField] private float currentMana;
    [SerializeField] private float manaRechargeRate = 10f;
    [SerializeField] private float timeBetweenCasts = 0.25f;
    private float currentCastTimer;

    [SerializeField] private Transform castPoint;

    private PlayerControlls playerControlls;

    private bool castingmagic = false;


    void Awake()
    {
        playerControlls = new PlayerControlls();

    }

    private void OnEnable()
    {
        playerControlls.Enable();
    }



    private void OnDisable()
    {
        playerControlls.Disable();
    }



    private void Update()
    {
        bool isSpellcastHeldDown = playerControlls.Controls.Spellcast.ReadValue<float>() > 0f;

        if (!castingmagic && isSpellcastHeldDown)
        {
            castingmagic = true;
            currentCastTimer = 0f;
            Castspell();
            print("Casting Magic!");
        }

        if (castingmagic)
        {
            currentCastTimer += Time.deltaTime;

        }

        if (currentCastTimer > timeBetweenCasts) castingmagic = false;
    }

    void Castspell()
    {
        Instantiate(spellToCast, castPoint.position, castPoint.rotation);
    }
}

using UnityEngine;
public class AnimationMorader : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private GameObject[] weapons;
    private int currentWeaponIndex = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        KeyPadPress();
        ScrollMouse();
    }
    private void KeyPadPress()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayJumpAttack();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Roar();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            HitFirst();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TakeDamage();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AttackHorizont();
        }
    }
    void PlayJumpAttack()
    {
        anim.Play("JumpAttack");
    }
    void Roar()
    {
        anim.Play("Roar");
    }
    void HitFirst()
    {
        anim.Play("HitFirst");
    }
    void TakeDamage()
    {
        anim.Play("TakeDamage");
    }
    void AttackHorizont()
    {
        anim.Play("AttackHorizont");
    }
    private void ScrollMouse()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0)
        {
            currentWeaponIndex++;
            if (currentWeaponIndex >= weapons.Length)
            {
                currentWeaponIndex = 0;
            }
        }
        else if (scroll < 0)
        {
            currentWeaponIndex--;
            if (currentWeaponIndex < 0)
            {
                currentWeaponIndex = weapons.Length - 1;
            }
        }
        for (int i = 0; i < weapons.Length; i++)
        {
            if (i == currentWeaponIndex)
            {
                weapons[i].SetActive(true);
            }
            else
            {
                weapons[i].SetActive(false);
            }
        }
    }
}

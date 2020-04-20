using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    Weapon currentWeapon;
    List<Weapon> fieldWeapons = new List<Weapon>();

    [SerializeField]
    Weapon[] weaponPrefabs;

    public void Fire()
    {
        if (currentWeapon == null)
            return;

        currentWeapon.Fire();
    }

    void Start()
    {
        StartCoroutine(CGenerateWeaponDelay(5f));
    }

    void GenerateWeapon(Weapon weapon, Vector3 position)
    {
        Weapon generatedWeapon = Instantiate(weapon, position, Quaternion.identity);
        generatedWeapon.WeaponPicked += SetWeapon;
        fieldWeapons.Add(generatedWeapon);
    }

    void SetWeapon(Weapon weapon)
    {
        weapon.gameObject.SetActive(false);
        currentWeapon = weapon;
        fieldWeapons.Find(x => currentWeapon).WeaponPicked -= SetWeapon;
        fieldWeapons.Remove(currentWeapon);
    }

    IEnumerator CGenerateWeaponDelay(float delay = 5f)
    {
        while (true)
        {
            GenerateWeapon(weaponPrefabs[Random.Range(0, weaponPrefabs.Length + 1)], new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0));
            yield return new WaitForSeconds(delay);
        }
    }
}

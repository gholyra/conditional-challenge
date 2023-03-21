using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKills : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int deadEnemies;
    [SerializeField] private bool isBossDead;
    private bool killedAll;

    void Start()
    {

        if(deadEnemies == 100)
        {
            print("Matou todos os inimigos -> Você ganhou o Prêmio Top!!! =)");
            killedAll = true;
        } 
        else if(deadEnemies >= 50)
        {
            print("Matou mais da metade dos inimigos -> Você ganhou o Prêmio Bom :)");
            killedAll = false;
        } 
        else if(deadEnemies > 0)
        {
            print("Matou menos da metade dos inimigos -> Você não ganhou nenhum prêmio :/");
        } 
        else
        {
            print("Você não matou nenhum inimigo >:(");
        }

        if(isBossDead == true && killedAll == true)
        {
            print("Matou o boss e todos os inimigos -> Você ganhou o Prêmio Lendário!!! =)");
        } 
        else if(isBossDead == true && killedAll == false)
        {
            print("Matou o boss mas não matou todos os inimigos -> Você ganhou o Prêmio Bom :)");
        } 
        else if(isBossDead == false && killedAll == false)
        {
            print("Não matou o boss e não matou todos os inimigos -> Você não ganhou nenhum prêmio :/");
        } 
        else if(isBossDead == false && deadEnemies == 0)
        {
            print("Que pena que você não conseguiu matar nenhum dos dois :(");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

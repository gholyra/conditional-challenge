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
            print("Matou todos os inimigos -> Voc� ganhou o Pr�mio Top!!! =)");
            killedAll = true;
        } 
        else if(deadEnemies >= 50)
        {
            print("Matou mais da metade dos inimigos -> Voc� ganhou o Pr�mio Bom :)");
            killedAll = false;
        } 
        else if(deadEnemies > 0)
        {
            print("Matou menos da metade dos inimigos -> Voc� n�o ganhou nenhum pr�mio :/");
        } 
        else
        {
            print("Voc� n�o matou nenhum inimigo >:(");
        }

        if(isBossDead == true && killedAll == true)
        {
            print("Matou o boss e todos os inimigos -> Voc� ganhou o Pr�mio Lend�rio!!! =)");
        } 
        else if(isBossDead == true && killedAll == false)
        {
            print("Matou o boss mas n�o matou todos os inimigos -> Voc� ganhou o Pr�mio Bom :)");
        } 
        else if(isBossDead == false && killedAll == false)
        {
            print("N�o matou o boss e n�o matou todos os inimigos -> Voc� n�o ganhou nenhum pr�mio :/");
        } 
        else if(isBossDead == false && deadEnemies == 0)
        {
            print("Que pena que voc� n�o conseguiu matar nenhum dos dois :(");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

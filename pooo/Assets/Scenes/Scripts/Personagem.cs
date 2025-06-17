using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int nivel;
    public int vida;
    public int forca;

    public void SetNome(string nome) => this.nome = nome;
    public string GetNome() => nome;

    public void SetNivel(int nivel) => this.nivel = nivel;
    public int GetNivel() => nivel;

    public void SetVida(int vida) => this.vida = vida;
    public int GetVida() => vida;

    public void SetForca(int forca) => this.forca = forca;
    public int GetForca() => forca;

    public void CompararNivel(Personagem outro)
    {
        if (this.nivel > outro.nivel)
            Debug.Log($"{nome} está em um nível mais alto que {outro.nome}.");
        else if (this.nivel < outro.nivel)
            Debug.Log($"{outro.nome} está em um nível mais alto que {nome}.");
        else
            Debug.Log($"{nome} e {outro.nome} estão no mesmo nível.");
    }
}




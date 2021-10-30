using System;

namespace ResistenciaBasica.Domain
{
    public interface ICalcularColor
    {
        void Calcular(string Color1, string Color2, string Color3, double valor1, double valor2, double valor3);
         string RetornarResultado();
    }
}
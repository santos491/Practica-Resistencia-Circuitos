using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.IO;
using System;


namespace ResistenciaBasica.Domain
{
    public class CircuitoBasico : ICalcularColor
     {
        private string _Color1 = "";
        private string _Color2 = "";
        private string _Color3 = "";
        private double _valor1 = 0.0;
        private double _valor2 = 0.0;
        private double _valor3 = 0.0;
        private double _resultado1 = 0.0;
        private double _resultado2 = 0.0;

    
        public void Calcular(string Color1, string Color2, string Color3,double valor1,double valor2,double valor3)
        {
            _Color1 = Color1;
            _Color2 = Color2;
            _Color3 = Color3;

            _valor1 = valor1;
            _valor2 = valor2;
            _valor3 = valor3;

            _resultado1 = _valor1 * 10;
            _resultado2 = (_resultado1 + _valor2) * valor3;
            
        }
        public string RetornarResultado()
        {
            return $" Banda 1={_Color1} valor es:{ _valor1 }, Banda 2={_Color2} valor es:{ _valor2}, Banda 3={_Color3} Multiplicador es:{ _valor3}, SU RESISTENCIA ES {_valor1}{_valor2} * {_valor3} ={_resultado2}";

        }
    }      
}
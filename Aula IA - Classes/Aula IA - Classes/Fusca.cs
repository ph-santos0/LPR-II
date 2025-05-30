using System;

namespace Aula_IA___Classes
{
    public class Fusca
    {
        private string placa;
        private string corLataria;
        private string corParachoque;
        private int aro;
        private string tipoVidro;

        public bool status = false;
        public int velocidade = 0;
        public int marcha = 0;

        public Fusca()
        {
            placa = "";
            corLataria = "";
            corParachoque = "";
            aro = 14;
            tipoVidro = "comum";
        }

        public Fusca(string placa, string corLataria, string corParachoque, int aro, string tipoVidro)
        {
            this.placa = placa;
            this.corLataria = corLataria;
            this.corParachoque = corParachoque;
            this.aro = aro;
            this.tipoVidro = tipoVidro;
        }

        public string Placa { get => placa; set => placa = value; }
        public string CorLataria { get => corLataria; set => corLataria = value; }
        public string CorParachoque { get => corParachoque; set => corParachoque = value; }
        public int Aro { get => aro; set => aro = value; }
        public string TipoVidro { get => tipoVidro; set => tipoVidro = value; }

        public void Ligar()
        {
            status = true;
        }
        public void Desigar()
        {
            status = false;
        }
        public void Acelerar()
        {
            velocidade += marcha * 10;
        }
        public void frear()
        {
            velocidade -= marcha * 10;
        }
        public void TrocarMarcha()
        {
            marcha = (marcha + 1) % 5;
        }
        public String imprimir()
        {
            String s = "";
            s += placa + "\n" + corLataria + "\n" + corParachoque + "\n" + aro + "\n" + tipoVidro;
            return s;
        }
    }
}

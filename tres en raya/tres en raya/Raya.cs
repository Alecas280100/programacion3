using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres_en_raya
{
    class Raya
    {
        private char[,] tabla;
        private int turno;
        public Raya()
        {
            turno = 1;
            tabla = new char[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    tabla[i, j] = '-';
                }
            }
        }
        public String marcar(int x, int y, char marca)
        {
            int turnomarcacion = 0;
            if (marca == 'X')
                turnomarcacion = 1;
            else
                turnomarcacion = 2;
            if (turnomarcacion == turno)
            {
                if (tabla[x, y] == '-')
                {
                    tabla[x, y] = marca;
                    if (ganador(marca))
                    {
                        return "ganador:" + marca.ToString();
                    }
                    else
                    {
                        if (Empate())
                        {
                            return "resultado: empate";
                        }
                        else
                        {
                            turno = (turno % 2) + 1;
                            return "Continuar: juego";
                        }
                    }
                }
                else
                    return "error:posicion ocupada";
            }
            else
                return "error:turno incorrecto";
        }
        public Boolean ganador(char marca)
        {
            Boolean gana = false;
            if (tabla[0, 0] == marca && tabla[0, 1] == marca && tabla[0, 2] == marca)
            { gana = true; } 
            if (tabla[0,0]  == marca && tabla[1,0]  == marca && tabla[2,0 ]==  marca)
            { gana = true; }
            if (tabla[0, 1] == marca && tabla[1, 1] == marca && tabla[2, 1] == marca)
            { gana = true; }
            if (tabla[0, 2] == marca && tabla[1, 2] == marca && tabla[2, 2] == marca)
            { gana = true; }
            if (tabla[1, 0] == marca && tabla[1, 1] == marca && tabla[1, 2] == marca)
            { gana = true; }
            if (tabla[2, 0] == marca && tabla[2, 1] == marca && tabla[2, 2] == marca)
            { gana = true; }
            if (tabla[0, 0] == marca && tabla[1, 1] == marca && tabla[2, 2] == marca)
            { gana = true; }
            if (tabla[2, 0] == marca && tabla[1, 1] == marca && tabla[0, 2] == marca)
            { gana = true; }
            return gana;
        }
        public Boolean Empate()
        {
            bool empate = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabla[i, j] == '-')
                        empate = false;
                }
            }
            return empate;
        }
        public void Reiniciar()
        {
            turno = 1;
            tabla = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabla[i, j] = '-';
                }
            }
        }

    }
}

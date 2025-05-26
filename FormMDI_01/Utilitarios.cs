using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMDI_01
{
    internal static class Utilitarios
    {
        public static string ConverterSegundos(int totalSegundos)
        {
            int horas = totalSegundos / 3600;
            int minutos = (totalSegundos % 3600) / 60;
            int segundos = totalSegundos % 60;

            return $"{horas}h {minutos}m {segundos}s";
        }

        public static List<int> ObterNumerosPares(int inicio, int fim)
        {
            List<int> pares = new List<int>();
            for (int i = inicio + 1; i < fim; i++)
            {
                if (i % 2 == 0)
                    pares.Add(i);
            }
            return pares;
        }

        public static double ConverterTemperatura(double celsius, string tipo)
        {
            return tipo == "K" ? celsius + 273.15 : (celsius * 9 / 5) + 32;
        }

        public static bool EhDivisivelPor3(int numero)
        {
            return numero % 3 == 0;
        }

        public static int CalcularIdade(DateTime nascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - nascimento.Year;
            if (nascimento > hoje.AddYears(-idade)) idade--;
            return idade;
        }

        public static double DobroOuMetade(int numero)
        {
            return numero % 2 == 0 ? numero * 2 : numero / 2.0;
        }

        public static int DiferencaMaiorMenor(int a, int b)
        {
            return Math.Abs(a - b);
        }

        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public static string AvaliarNota(double nota)
        {
            if (nota == 10) return "Excelente";
            if (nota >= 8) return "Muito bom";
            if (nota >= 7) return "Bom";
            if (nota >= 0 && nota < 7) return "Insatisfatório";
            return "Nota inválida";
        }

        public static int DiasEntreDatas(DateTime data1, DateTime data2)
        {
            return Math.Abs((data1 - data2).Days);
        }

        public static (int faixa1, int faixa2, int faixa3, int faixa4) AnalisarFaixas(List<int> numeros)
        {
            int faixa1 = 0, faixa2 = 0, faixa3 = 0, faixa4 = 0;
            foreach (int n in numeros)
            {
                if (n >= 0 && n <= 25) faixa1++;
                else if (n <= 50) faixa2++;
                else if (n <= 75) faixa3++;
                else if (n <= 100) faixa4++;
            }
            return (faixa1, faixa2, faixa3, faixa4);
        }

        public static List<int> NumerosRepetidos(List<int> array1, List<int> array2)
        {
            List<int> repetidos = new List<int>();
            foreach (int n in array1)
            {
                if (array2.Contains(n) && !repetidos.Contains(n))
                    repetidos.Add(n);
            }
            return repetidos;
        }

        public static int ContarLetra(string frase, char letra)
        {
            int count = 0;
            foreach (char c in frase)
            {
                if (char.ToLower(c) == char.ToLower(letra))
                    count++;
            }
            return count;
        }

        public static bool EhAnoBissexto(int ano)
        {
            return DateTime.IsLeapYear(ano);
        }

        public static int SomaMultiplicadaPorIndice(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i] * i;
            }
            return soma;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMDI_01
{
    // Classe utilitária com métodos estáticos para diversas operações
    internal static class Utilitarios
    {
        /// <summary>
        /// Converte um valor em segundos para uma string no formato "Xh Ym Zs".
        /// </summary>
        /// <param name="totalSegundos">Total de segundos a converter.</param>
        /// <returns>String formatada com horas, minutos e segundos.</returns>
        public static string ConverterSegundos(int totalSegundos)
        {
            int horas = totalSegundos / 3600; // Calcula o número de horas
            int minutos = (totalSegundos % 3600) / 60; // Calcula o número de minutos restantes
            int segundos = totalSegundos % 60; // Calcula os segundos restantes

            return $"{horas}h {minutos}m {segundos}s"; // Retorna a string formatada
        }

        /// <summary>
        /// Retorna uma lista com todos os números pares entre dois valores (exclusivo).
        /// </summary>
        /// <param name="inicio">Valor inicial (não incluído).</param>
        /// <param name="fim">Valor final (não incluído).</param>
        /// <returns>Lista de números pares.</returns>
        public static List<int> ObterNumerosPares(int inicio, int fim)
        {
            List<int> pares = new List<int>(); // Lista para armazenar os pares
            for (int i = inicio + 1; i < fim; i++) // Percorre os números entre inicio e fim
            {
                if (i % 2 == 0) // Verifica se o número é par
                    pares.Add(i); // Adiciona à lista
            }
            return pares; // Retorna a lista de pares
        }

        /// <summary>
        /// Converte temperatura de Celsius para Kelvin ou Fahrenheit.
        /// </summary>
        /// <param name="celsius">Temperatura em Celsius.</param>
        /// <param name="tipo">"K" para Kelvin, qualquer outro valor para Fahrenheit.</param>
        /// <returns>Temperatura convertida.</returns>
        public static double ConverterTemperatura(double celsius, string tipo)
        {
            // Se tipo for "K", converte para Kelvin, senão para Fahrenheit
            return tipo == "K" ? celsius + 273.15 : (celsius * 9 / 5) + 32;
        }

        /// <summary>
        /// Verifica se um número é divisível por 3.
        /// </summary>
        /// <param name="numero">Número a ser verificado.</param>
        /// <returns>True se for divisível, senão False.</returns>
        public static bool EhDivisivelPor3(int numero)
        {
            return numero % 3 == 0; // Retorna verdadeiro se o resto da divisão por 3 for zero
        }

        /// <summary>
        /// Calcula a idade com base na data de nascimento.
        /// </summary>
        /// <param name="nascimento">Data de nascimento.</param>
        /// <returns>Idade em anos.</returns>
        public static int CalcularIdade(DateTime nascimento)
        {
            DateTime hoje = DateTime.Today; // Data atual
            int idade = hoje.Year - nascimento.Year; // Diferença de anos
            if (nascimento > hoje.AddYears(-idade)) idade--; // Ajusta se ainda não fez aniversário no ano
            return idade; // Retorna a idade
        }

        /// <summary>
        /// Retorna o dobro se o número for par, ou a metade se for ímpar.
        /// </summary>
        /// <param name="numero">Número a ser avaliado.</param>
        /// <returns>Dobro ou metade do número.</returns>
        public static double DobroOuMetade(int numero)
        {
            // Se par, retorna o dobro; se ímpar, retorna a metade
            return numero % 2 == 0 ? numero * 2 : numero / 2.0;
        }

        /// <summary>
        /// Calcula a diferença absoluta entre dois números.
        /// </summary>
        /// <param name="a">Primeiro número.</param>
        /// <param name="b">Segundo número.</param>
        /// <returns>Valor absoluto da diferença.</returns>
        public static int DiferencaMaiorMenor(int a, int b)
        {
            return Math.Abs(a - b); // Retorna a diferença absoluta
        }

        /// <summary>
        /// Calcula o IMC (Índice de Massa Corporal).
        /// </summary>
        /// <param name="peso">Peso em kg.</param>
        /// <param name="altura">Altura em metros.</param>
        /// <returns>Valor do IMC.</returns>
        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura); // Fórmula do IMC
        }

        /// <summary>
        /// Avalia uma nota e retorna uma string correspondente ao desempenho.
        /// </summary>
        /// <param name="nota">Nota a ser avaliada.</param>
        /// <returns>Descrição da avaliação.</returns>
        public static string AvaliarNota(double nota)
        {
            if (nota == 10) return "Excelente"; // Nota máxima
            if (nota >= 8) return "Muito bom"; // Nota entre 8 e 9.9
            if (nota >= 7) return "Bom"; // Nota entre 7 e 7.9
            if (nota >= 0 && nota < 7) return "Insatisfatório"; // Nota entre 0 e 6.9
            return "Nota inválida"; // Qualquer outro valor
        }

        /// <summary>
        /// Calcula o número de dias entre duas datas.
        /// </summary>
        /// <param name="data1">Primeira data.</param>
        /// <param name="data2">Segunda data.</param>
        /// <returns>Número absoluto de dias entre as datas.</returns>
        public static int DiasEntreDatas(DateTime data1, DateTime data2)
        {
            return Math.Abs((data1 - data2).Days); // Diferença absoluta em dias
        }

        /// <summary>
        /// Conta quantos números estão em cada uma das quatro faixas: 0-25, 26-50, 51-75, 76-100.
        /// </summary>
        /// <param name="numeros">Lista de números a analisar.</param>
        /// <returns>Tupla com a contagem de cada faixa.</returns>
        public static (int faixa1, int faixa2, int faixa3, int faixa4) AnalisarFaixas(List<int> numeros)
        {
            int faixa1 = 0, faixa2 = 0, faixa3 = 0, faixa4 = 0; // Inicializa contadores
            foreach (int n in numeros) // Percorre a lista
            {
                if (n >= 0 && n <= 25) faixa1++; // Faixa 0-25
                else if (n <= 50) faixa2++; // Faixa 26-50
                else if (n <= 75) faixa3++; // Faixa 51-75
                else if (n <= 100) faixa4++; // Faixa 76-100
            }
            return (faixa1, faixa2, faixa3, faixa4); // Retorna as contagens
        }

        /// <summary>
        /// Retorna uma lista com os números que aparecem em ambos os arrays, sem repetições.
        /// </summary>
        /// <param name="array1">Primeiro array de inteiros.</param>
        /// <param name="array2">Segundo array de inteiros.</param>
        /// <returns>Lista de números repetidos.</returns>
        public static List<int> NumerosRepetidos(List<int> array1, List<int> array2)
        {
            List<int> repetidos = new List<int>(); // Lista para armazenar os repetidos
            foreach (int n in array1) // Percorre o primeiro array
            {
                // Adiciona se estiver no segundo array e ainda não foi adicionado
                if (array2.Contains(n) && !repetidos.Contains(n))
                    repetidos.Add(n);
            }
            return repetidos; // Retorna a lista
        }

        /// <summary>
        /// Conta quantas vezes uma letra aparece em uma frase (case insensitive).
        /// </summary>
        /// <param name="frase">Frase para busca.</param>
        /// <param name="letra">Letra a ser contada.</param>
        /// <returns>Número de ocorrências da letra.</returns>
        public static int ContarLetra(string frase, char letra)
        {
            int count = 0; // Contador de ocorrências
            foreach (char c in frase) // Percorre cada caractere
            {
                if (char.ToLower(c) == char.ToLower(letra)) // Compara ignorando maiúsculas/minúsculas
                    count++;
            }
            return count; // Retorna o total
        }

        /// <summary>
        /// Verifica se um ano é bissexto.
        /// </summary>
        /// <param name="ano">Ano a ser verificado.</param>
        /// <returns>True se for bissexto, senão False.</returns>
        public static bool EhAnoBissexto(int ano)
        {
            return DateTime.IsLeapYear(ano); // Usa método do .NET para verificar
        }

        /// <summary>
        /// Soma cada elemento do vetor multiplicado pelo seu índice.
        /// </summary>
        /// <param name="vetor">Vetor de inteiros.</param>
        /// <returns>Soma dos produtos.</returns>
        public static int SomaMultiplicadaPorIndice(int[] vetor)
        {
            int soma = 0; // Inicializa a soma
            for (int i = 0; i < vetor.Length; i++) // Percorre o vetor
            {
                soma += vetor[i] * i; // Multiplica elemento pelo índice e soma
            }
            return soma; // Retorna o resultado
        }
    }
}
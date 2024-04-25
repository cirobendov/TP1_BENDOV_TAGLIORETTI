using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace TP1_BENDOV_TAGLIORETTI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cuotas;
            int[] cuotasPosibles = { 1, 3, 6, 12, 18, 24 };
            double dias;
            List<DateTime> fechasCompra = new List<DateTime>();
            DateTime fecha1, fecha2;
            //fecha1 = ingresarDateTime("Ingrese una fecha");
            //fecha2 = ingresarDateTime("Ingrese la otra fecha");
            //dias = devoDiasEntreCumples(fecha1, fecha2);
            //Console.WriteLine("Hay " + dias + " dias entre los dos cumpleaños.");

            fecha1 = ingresarDateTime("Ingrese la fecha de compra");
            do
            {
                Console.WriteLine("Ingrese una cantidad de cuotas");
                cuotas = int.Parse(Console.ReadLine());

            } while (Array.IndexOf(cuotasPosibles, cuotas) == -1);
            fechasCompra = obtenerFechasCompra(fecha1, cuotas);
            for (int i = 0; i < cuotas; i++)
            {
                Console.Write(", " + fechasCompra[i]);
            }
            
        }
        public static double devoDiasEntreCumples(DateTime fecha1, DateTime fecha2)
        {
            double dias;
            dias = (fecha1 - fecha2).TotalDays;
            if (dias < 0)
            {
                dias = -dias;
            }
            return dias;
        }
        public static DateTime ingresarDateTime(string mensaje)
        {
            int[] meses31 = new int[7] {1, 3, 5, 7, 8, 10, 12};
            int[] meses30 = new int[4] {4, 6, 9, 11,};
            int dia, año, mes;
            do
            {            
                Console.WriteLine("Ingrese un dia");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un mes");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un año");
                año = int.Parse(Console.ReadLine());
               

            } while (dia > 31 || dia < 1 && dia == 31 && Array.IndexOf(meses31, mes) == -1 || mes < 1 && mes > 12 || mes == 2 && dia > 28);           
            DateTime fecha = new DateTime(año, mes, dia);
            return fecha;
        }
        public static List <DateTime> obtenerFechasCompra(DateTime fecha, int cuotas)
        {
            List <DateTime> fechasCompra = new List <DateTime> ();
            for (int i = 0; i < cuotas; i++)
            {
                fechasCompra.Add(fecha.AddMonths(i));
            }
            return fechasCompra;
        }
    }   
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el punto preferido:");
            int punto = int.Parse(Console.ReadLine());

            switch (punto)
            {
                case 1:
                    #region Punto 1

                    var variableUno = 1;
                    var variableDos = 2;
                    var variableTres = 3;

                    var Suma = variableUno + variableDos + variableTres;
                    Console.WriteLine(Suma);
                    break;
                #endregion

                case 2:
                    #region Punto 2

                    int numUno = int.Parse(Console.ReadLine());
                    int numDos = int.Parse(Console.ReadLine());

                    if (numUno >= numDos)
                    {
                        Console.WriteLine(numUno);
                    }
                    else
                    {
                        Console.WriteLine(numDos);
                    }
                    break;
                #endregion

                case 3:
                    #region Punto 3

                    Console.WriteLine("Ingrese un dia de la semana");
                    string dia = Console.ReadLine();

                    if (String.Equals(dia, "sabado", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(dia, "domingo", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(dia + " es fin de semana");
                    }
                    else if (String.Equals(dia, "lunes", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(dia, "martes", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(dia, "miercoles", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(dia, "jueves", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(dia, "viernes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(dia + " no es fin de semana");
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                    break;
                #endregion

                case 4:
                    #region Punto 4
                    Console.WriteLine("Ingrese precio de producto:");
                    int precio = int.Parse(Console.ReadLine());
                    if (precio < 0)
                    {
                        Console.WriteLine("ERROR precio negativo. Ingrese precio de producto:");
                        precio = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Ingrese forma de pago: (tarjeta/efectivo)");
                    String formaDePago = Console.ReadLine();

                    if (String.Equals(formaDePago, "tarjeta", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Ingrese numero de cuenta: ");
                        int numeroDeCuenta = int.Parse(Console.ReadLine());
                    }
                    break;
                #endregion

                case 5:
                    #region Punto 5
                    for (int i = 1; i < 101; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                #endregion

                case 6:
                    #region Punto 6
                    int i6 = 1;
                    while (i6 < 101)
                    {
                        Console.Write(i6 + " ");
                        i6++;
                    }
                    break;
                #endregion

                case 7:
                    #region Punto 7
                    for (int i7 = 1; i7 < 101; i7++)
                    {
                        if (i7 % 2 == 0)
                        {
                            Console.Write(i7 + " ");
                        }
                    }
                    break;
                #endregion

                case 8:
                    #region Punto 8
                    for (int i8 = 1; i8 < 101; i8++)
                    {
                        if (i8 % 2 == 0 || i8 % 3 == 0)
                        {
                            Console.Write(i8 + " ");
                        }
                    }
                    break;
                #endregion

                case 9:
                    #region Punto 9
                    int iteradorPar = 0;
                    for (int i91 = 1; i91 < 101; i91++)
                    {
                        if (i91 % 2 == 0)
                        {
                            iteradorPar++;
                        }
                    }
                    int[] arregloPar = new int[iteradorPar];
                    int iteradorArreglo = 0;
                    for (int i92 = 1; i92 < 101; i92++)
                    {
                        if (i92 % 2 == 0)
                        {
                            arregloPar[iteradorArreglo] = i92;
                            Console.Write(arregloPar[iteradorArreglo] + " ");
                        }
                    }
                    break;
                #endregion

                case 10:
                    #region Punto 10
                    int sumatoriaNumerosPares = 0;
                    int sumatoriaNumerosImpares = 0;
                    int numeroEntrante = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        numeroEntrante = int.Parse(Console.ReadLine());
                        if (numeroEntrante % 2 == 0)
                        {
                            sumatoriaNumerosPares = sumatoriaNumerosPares + numeroEntrante;
                        }
                        else
                        {
                            sumatoriaNumerosImpares = sumatoriaNumerosImpares + numeroEntrante;
                        }
                    }

                    int sumaFinal = sumatoriaNumerosPares - sumatoriaNumerosImpares;
                    Console.WriteLine(sumaFinal);
                    #endregion
                    break;

                case 11:
                    #region Punto 11
                    Console.WriteLine("Ingrese un numero del 1 al 7");
                    int diaSemanaNumero = int.Parse(Console.ReadLine());
                    String[] diasDeLaSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
                    switch (diaSemanaNumero)
                    {
                        case 1:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        case 2:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        case 3:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        case 4:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        case 5:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        case 6:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        case 7:
                            Console.WriteLine(diasDeLaSemana[diaSemanaNumero - 1]);
                            break;

                        default:
                            break;
                    }
                    #endregion
                    break;

                case 12:
                    #region Punto 12

                    Console.WriteLine("Ingrese un numero del 1 al 1000");
                    int numeroUsuario = int.Parse(Console.ReadLine());
                    int sumatoria = 0;

                    if (numeroUsuario < 1 && numeroUsuario > 1000)
                    {
                        Console.WriteLine("Error de rango. Ingrese otro numero");
                        numeroUsuario = int.Parse(Console.ReadLine());
                    }

                    for (int i12 = 1; i12 <= numeroUsuario; i12++)
                    {
                        sumatoria = sumatoria + i12;
                    }

                    var media = sumatoria / numeroUsuario;
                    Console.WriteLine("Sumatoria: " + sumatoria);
                    Console.WriteLine("Media: " + media);
                    #endregion
                    break;

                case 13:
                    #region Punto 13
                    Console.WriteLine("Ingrese un numero:");
                    int numeroPrimo = int.Parse(Console.ReadLine());
                    int iDivisores = 0;

                    for (int i13 = 1; i13 <= numeroPrimo; i13++)
                    {
                        if (numeroPrimo % i13 == 0)
                        {
                            iDivisores++;
                        }

                    }
                    if (iDivisores == 2)
                    {
                        Console.WriteLine("Es primo!");
                    }
                    else
                    {
                        Console.WriteLine("NO es primo!");
                    }
                    #endregion
                    break;

                case 14:
                    #region Punto 14
                    Console.WriteLine("Ingrese un numero:");
                    int numeroUser = int.Parse(Console.ReadLine());
                    decimal numeroDividido = numeroUser;
                    int cifras = 1;

                    while (numeroDividido > 9)
                    {
                        numeroDividido = Math.Truncate(numeroDividido / 10);
                        cifras++;
                    }

                    Console.WriteLine("El numero tiene: " + cifras + " cifras");
                    #endregion
                    break;

                default:
                    break;
            }

        }
    }
}
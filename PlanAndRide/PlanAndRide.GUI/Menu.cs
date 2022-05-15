﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PlanAndRide.GUI
{
    internal static class Menu
    {
        private static int _inputMenu;
        public static void WelcomeMenu()
        {
            Console.WriteLine("Witaj w aplikacji Plan&Ride");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Stwórz konto");
            Console.WriteLine("2. Zaloguj się");
            Console.WriteLine("3. Wejdź jako gość");
            Console.WriteLine("-------------------------");

            var userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                _inputMenu = int.Parse(userInput);
            }
            Console.WriteLine("-------------------------");
            switch (_inputMenu)
            {
                case 1: 
                    Console.WriteLine("\nTworzymy konto..."); 
                    break;

                case 2: 
                    Console.WriteLine("\nWitaj zalogowany użytkowniku...");
                    LoggedUserMenu();
                    break;

                case 3:
                    Console.WriteLine("\nWitaj gościu...");
                    GuestMenu();
                    break;

                default:
                    Console.WriteLine("\nProszę wybrać opcję 1 - 3 ");
                    break;
            }
        }

        public static void GuestMenu()
        {
            Console.Clear();
            Console.WriteLine(
                $"Jeśli chcesz skorzystać ze wszystkich funkcjonalności naszej aplikacji to " +
                $"zachęcamy Cię do zalogowania się lub utworzenia konta");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Stwórz konto");
            Console.WriteLine("2. Zaloguj się");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Wybierz opcję: ");
            Console.WriteLine("3. Wyszukaj trasę:");
            Console.WriteLine("4. Wyszukaj event:");
            Console.WriteLine("5. Wyjdź z aplikacji:");
            Console.WriteLine("-------------------------");

            var userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                _inputMenu = int.Parse(userInput);
            }
            Console.WriteLine("-------------------------");
            switch (_inputMenu)
            {
                case 1:
                    Console.WriteLine("Tworzymy konto...");
                    break;

                case 2:
                    Console.WriteLine("\nWitaj zalogowany użytkowniku (nickname)...");
                    LoggedUserMenu();
                    break;

                case 3:
                    Console.WriteLine("Lista wyszukanych tras...");
                    break;

                case 4:
                    Console.WriteLine("Lista wyszukanych eventów...");
                    break;

                case 5:
                    Console.WriteLine("Dziękujemy za skorzystanie z aplikacji Plan&Ride...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Proszę wybrać opcję 1 - 5 ");
                    break;
            }
        }

        public static void LoggedUserMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Edytuj konto");
            Console.WriteLine("2. Wyloguj się");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Wybierz opcję: ");
            Console.WriteLine("3. Stwórz trasę");
            Console.WriteLine("4. Wyszukaj trasę");
            Console.WriteLine("5. Edytuj trasę");
            Console.WriteLine("6. Usuń trasę");
            Console.WriteLine("7. Udostępnij trasę");
            Console.WriteLine("8. Oceń trasę");
            Console.WriteLine("9. Historia tras");
            Console.WriteLine("10. Stwórz event");
            Console.WriteLine("11. Wyszukaj event");
            Console.WriteLine("12. Edytuj event");
            Console.WriteLine("13. Ustawienia powiadomień");
            Console.WriteLine("14. Wyjdź");
            Console.WriteLine("-------------------------");

            var userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                _inputMenu = int.Parse(userInput);
            }
            Console.WriteLine("-------------------------");
            switch (_inputMenu)
            {
                case 1:
                    Console.WriteLine("Tworzymy konto...");
                    break;

                case 2:
                    Console.WriteLine("Witaj zalogowany użytkowniku...");
                    break;

                case 3:
                    Console.WriteLine("Tworzymy trasę...");
                    break;

                case 4:
                    Console.WriteLine("Lista wyszukanych tras...");
                    break;

                case 5:
                    Console.WriteLine("Edytujemy trasę...");
                    break;

                case 6:
                    Console.WriteLine("Usuwamy trasę...");
                    break;

                case 7:
                    Console.WriteLine("Udostępniamy trasę...");
                    break;

                case 8:
                    Console.WriteLine("Oceniamy trasę...");
                    break;

                case 9:
                    Console.WriteLine("Przeglądamy historię tras...");
                    break;

                case 10:
                    Console.WriteLine("Tworzymy event...");
                    break;

                case 11:
                    Console.WriteLine("Wyszukujemy event...");
                    break;

                case 12:
                    Console.WriteLine("Edytujemy event...");
                    break;

                case 13:
                    Console.WriteLine("Ustawiamy powiadomienia...");
                    break;

                case 14:
                    Console.WriteLine("Dziękujemy za skorzystanie z aplikacji Plan&Ride...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Proszę wybrać opcję 1 - 14 ");
                    break;
            }
        }
    }
}

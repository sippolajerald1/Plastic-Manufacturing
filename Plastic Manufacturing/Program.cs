using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plastic_Manufacturing
{
    class Program
    {

        // **************************************************
        //
        // Title: Plastics Manufacturing Program
        // Application Type: Console
        // Description: Select plastic type and price of part
        // Author: Jerald Sippola
        // Last Modified: 12/4/29
        //
        // ************************************************** 

     
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            Console.WriteLine();
            Console.WriteLine("Please enter user name: ");
            string name = (Console.ReadLine());
            // Console.WriteLine("Please enter password: ");
            // string password = (Console.ReadLine());
            // if (password == "InkPen")

            {
                Console.WriteLine("");
                Console.WriteLine("Hello, {0} ", name);
                Console.WriteLine();
                Console.WriteLine("Please enter volume: ");
                double volume = double.Parse(Console.ReadLine());

                DisplayMenuScreen();

                void DisplayMenuScreen()
                {
                    bool quitApplication = false;
                    int menuChoice;
                    do
                    {
                        DisplayScreenHeader("Plastics Menu");

                        //
                        // get user menu choice
                        //
                        Console.WriteLine("1) ABS - Acrylonitrile Butadine Styrene");
                        Console.WriteLine("2) HDPE - High Density Polyethylene");
                        Console.WriteLine("3) LDPE - Low Density Polyethylene");
                        Console.WriteLine("4) Nylon - Polyamide");
                        Console.WriteLine("5) PC - Polycarbonate");
                        Console.WriteLine("6) PC/ABS - Polycarbonate/Acrylonitrile Butadiene Styrene");
                        Console.WriteLine("7) PP - Polypropylene");
                        Console.WriteLine("8) PS - Polystyrene");
                        Console.WriteLine("0) Quit");
                        Console.WriteLine();
                        Console.Write("Enter plastic number for details of plastic:");
                        menuChoice = int.Parse(Console.ReadLine());

                        //
                        // process user menu choice
                        //
                        switch (menuChoice)
                        {
                            case 1:

                                DisplayABS(volume);
                                // Display ABS
                                break;

                            case 2:
                                DisplayHDPE(volume);
                                // DisplayHDPE
                                break;

                            case 3:
                                DisplayLDPE(volume);
                                // DisplayLDPE
                                break;

                            case 4:
                                DisplayNylonPolyamide(volume);
                                //DisplayNylon - Polyamide
                                break;

                            case 5:
                                DisplayPCPolycarbonate(volume);
                                //DisplayPC
                                break;

                            case 6:
                                DisplayPCABS(volume);
                                // DisplayPCABS
                                break;

                            case 7:
                                DisplayPP(volume);
                                // DisplayPP
                                break;

                            case 8:
                                DisplayPS(volume);
                                //DisplayPS
                                break;

                            case 0:
                                quitApplication = true;
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Please enter a number for the menu choice.");
                                DisplayContinuePrompt();
                                break;
                        }

                    } while (!quitApplication);
                }
            }

        }

        // 
        // ABS Display
        //

        static void DisplayABS(double volume)
        {
            DisplayScreenHeader("ABS - Acrylonitrile Butadiene Styrene");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Tough, impact resistant ");
            Console.WriteLine("Strong and stiff ");
            Console.WriteLine("Wide range of properties");
            Console.WriteLine("Moderate cost");
            Console.WriteLine("Moderately resistant to UV");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("Instrumental and door panels");
            Console.WriteLine("Telephone housings, Suitcases");
            Console.WriteLine("Appliances");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Plastic Unit price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", (volume * 1.77 * .037));
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.77 * .037));


            DisplayContinuePrompt();
        }

        //
        // Display HDPE
        //

        static void DisplayHDPE(double volume)
        {
            DisplayScreenHeader("HDPE - High Density Polyethylene");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Stiffness and strength");
            Console.WriteLine("Resistant to water and solvents");
            Console.WriteLine("Low Melting Point");
            Console.WriteLine("Inexpensive");
            Console.WriteLine("Excellent electrical resistance");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("Milk jugs, Toys, Trash Carts");
            Console.WriteLine("Pipe for natural gas");
            Console.WriteLine("Electrical wire coating");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", volume * 1.29 * .035);
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.29 * .035));


            DisplayContinuePrompt();
        }


        static void DisplayLDPE(double volume)
        {
            DisplayScreenHeader("LDPE - High Density Polyethylene");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Resistant to water and solvents");
            Console.WriteLine("Low Melting Point");
            Console.WriteLine("Inexpensive");
            Console.WriteLine("Excellent electrical resistance");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("Packaging films, Wire and Cable");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", volume * 1.39 * .033);
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.39 * .033));

            DisplayContinuePrompt();
        }

        static void DisplayNylonPolyamide(double volume)
        {
            DisplayScreenHeader("Nylon - Polyamide");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Stronger than ABS or PVC");
            Console.WriteLine("Tough");
            Console.WriteLine("Slightly water absorbant");
            Console.WriteLine("Abrasion Resistant");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("Carpets, ropes, gears");
            Console.WriteLine("Cloth (jackets, parachutes");
            Console.WriteLine("Automobile parts");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", (volume * 1.95 * 0.050));
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.95 * .050));

                       
            DisplayContinuePrompt();
        }

        static void DisplayPCPolycarbonate(double volume)
        {
            DisplayScreenHeader("PC - Polycarbonate");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Optically clear");
            Console.WriteLine("Tougher than Nylon(Polyamide)");
            Console.WriteLine("Not quite as strong or stiff as Nylon");
            Console.WriteLine("Inexpensive");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("High impact windows");
            Console.WriteLine("Impact automobile types");
            Console.WriteLine("Small Household appliances");
            Console.WriteLine("Electrical wire coating");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", (volume * 2.19 * 0.043));
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 2.19 * .043));


            DisplayContinuePrompt();
        }

        static void DisplayPCABS(double volume)
        {
            DisplayScreenHeader("PC/ABS");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Combination");
            Console.WriteLine("See polycarbonate");
            Console.WriteLine("See ABS");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("See polycarbonate");
            Console.WriteLine("See ABS");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", (volume * 1.89 * .0397));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.89 * .0397));


            DisplayContinuePrompt();
        }

        static void DisplayPP(double volume)
        {
            DisplayScreenHeader("Polypropylene");
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Resist stress cracking");
            Console.WriteLine("Stronger and stiffer than HDPE");
            Console.WriteLine("Resistant to water and solvents");
            Console.WriteLine("Low cost");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("Containers with integral hinges");
            Console.WriteLine("Microwave containers");
            Console.WriteLine("Utility fibres(woven, bags, ropes, carpets");
            Console.WriteLine("Bumper fascia, battery housings, Heating and ");
            Console.WriteLine("Air conditioning ducts");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", (volume * 1.10 * .033));
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.10 * .033));



            DisplayContinuePrompt();
        }
        static void DisplayPS(double volume)
        {
            DisplayScreenHeader("Polystyrene");
            Console.WriteLine();
            Console.WriteLine("General Properties:");
            Console.WriteLine("*****************************");
            Console.WriteLine("Stiffer than HDPE");
            Console.WriteLine("Clear, yellows with age");
            Console.WriteLine("Low cost but not as low as PE");
            Console.WriteLine("Brittle");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Applications: ");
            Console.WriteLine("******************************");
            Console.WriteLine("Cups and other containers");
            Console.WriteLine("Toys");
            Console.WriteLine("Foamed insulation cups and other objects");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price: ");
            Console.WriteLine();
            Console.WriteLine("{0:c}", (volume * 1.39 * 0.000036127));
            Console.WriteLine();
            Console.WriteLine("Enter scrap rate of part: ");
            double.TryParse(Console.ReadLine(), out double Scrap);
            //double Scrap = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0:c}", (Scrap * volume * 1.39 * .000036127));

            DisplayContinuePrompt();
        }



        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tPlastics Manufacturing");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

    }


}

using System;
using System.Collections.Generic;
using OpenTK.Input;

namespace OpenTK_Test
{
    //Creați o aplicație care la apăsarea unui set de taste va modifica
    //culoarea unui triunghi(coordonatele acestuia vor fi încărcate dintr-un
    //fișier text) între valorile minime și maxime, pentru fiecare canal de culoare.

    //Modificați aplicația pentru a manipula valorile RGB pentru fiecare
    //vertex ce definește un triunghi.Afișați valorile RGB în consolă.

    class Desenare
    {
        PreluareCoordonate data = new PreluareCoordonate();

        public double colorRed_V1 = 200;
        public double colorGreen_V1 = 1;
        public double colorBlue_V1 = 1;

        public double colorRed_V2 = 1;
        public double colorGreen_V2 = 200;
        public double colorBlue_V2 = 1;

        public double colorRed_V3 = 1;
        public double colorGreen_V3 = 1;
        public double colorBlue_V3 = 200;



        private void Valori()
        {
            Console.WriteLine("VERTEX 1 - Red:" + colorRed_V1 + " Green:" + colorGreen_V1 + " Blue:" + colorBlue_V1);
            Console.WriteLine("VERTEX 2 - Red:" + colorRed_V2 + " Green:" + colorGreen_V2 + " Blue:" + colorBlue_V2);
            Console.WriteLine("VERTEX 3 - Red:" + colorRed_V3 + " Green:" + colorGreen_V3 + " Blue:" + colorBlue_V3);
        }
        public void deseneaza()
        {
            List<int> poz = data.preluareCoordonate();

            KeyboardState keyboard = Keyboard.GetState();

            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////    VERTEX 1    //////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            if (colorRed_V1 < 255 && colorRed_V1 > 0)
            {
                if (keyboard[Key.Z])
                {
                    Console.Clear();
                    colorRed_V1++;
                    Valori();
                }
                else if (keyboard[Key.X])
                {
                    Console.Clear();
                    colorRed_V1--;
                    Valori();
                }
            }
            else if (colorRed_V1 >= 255)
            {
                if (keyboard[Key.X])
                {
                    Console.Clear();
                    colorRed_V1--;
                    Valori();
                }
            }
            else if (colorRed_V1 <= 0)
            {
                if (keyboard[Key.Z])
                {
                    Console.Clear();
                    colorRed_V1++;
                    Valori();
                }
            }



            if (colorGreen_V1 < 255 && colorGreen_V1 > 0)
            {
                if (keyboard[Key.C])
                {
                    Console.Clear();
                    colorGreen_V1++;
                    Valori();
                }
                else if (keyboard[Key.V])
                {
                    Console.Clear();
                    colorGreen_V1--;
                    Valori();
                }
            }
            else if (colorGreen_V1 >= 255)
            {
                if (keyboard[Key.V])
                {
                    Console.Clear();
                    colorGreen_V1--;
                    Valori();
                }
            }
            else if (colorGreen_V1 <= 0)
            {
                if (keyboard[Key.C])
                {
                    Console.Clear();
                    colorGreen_V1++;
                    Valori();
                }
            }



            if (colorBlue_V1 < 255 && colorBlue_V1 > 0)
            {
                if (keyboard[Key.B])
                {
                    Console.Clear();
                    colorBlue_V1++;
                    Valori();
                }
                else if (keyboard[Key.N])
                {
                    Console.Clear();
                    colorBlue_V1--;
                    Valori();
                }
            }
            else if (colorBlue_V1 >= 255)
            {
                if (keyboard[Key.N])
                {
                    Console.Clear();
                    colorBlue_V1--;
                    Valori();
                }
            }
            else if (colorBlue_V1 <= 0)
            {
                if (keyboard[Key.B])
                {
                    Console.Clear();
                    colorBlue_V1++;
                    Valori();
                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////    VERTEX 2    //////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////


            if (colorRed_V2 < 255 && colorRed_V2 > 0)
            {
                if (keyboard[Key.A])
                {
                    Console.Clear();
                    colorRed_V2++;
                    Valori();

                }
                else if (keyboard[Key.S])
                {
                    Console.Clear();
                    colorRed_V2--;
                    Valori();
                }
            }
            else if (colorRed_V2 >= 255)
            {
                if (keyboard[Key.S])
                {
                    Console.Clear();
                    colorRed_V2--;
                    Valori();
                }
            }
            else if (colorRed_V2 <= 0)
            {
                if (keyboard[Key.A])
                {
                    Console.Clear();
                    colorRed_V2++;
                    Valori();
                }
            }



            if (colorGreen_V2 < 255 && colorGreen_V2 > 0)
            {
                if (keyboard[Key.D])
                {
                    Console.Clear();
                    colorGreen_V2++;
                    Valori();
                }
                else if (keyboard[Key.F])
                {
                    Console.Clear();
                    colorGreen_V2--;
                    Valori();
                }
            }
            else if (colorGreen_V2 >= 255)
            {
                if (keyboard[Key.D])
                {
                    Console.Clear();
                    colorGreen_V2--;
                    Valori();
                }
            }
            else if (colorGreen_V2 <= 0)
            {
                if (keyboard[Key.F])
                {
                    Console.Clear();
                    colorGreen_V2++;
                    Valori();
                }
            }



            if (colorBlue_V2 < 255 && colorBlue_V2 > 0)
            {
                if (keyboard[Key.G])
                {
                    Console.Clear();
                    colorBlue_V2++;
                    Valori();
                }
                else if (keyboard[Key.H])
                {
                    Console.Clear();
                    colorBlue_V2--;
                    Valori();
                }
            }
            else if (colorBlue_V2 >= 255)
            {
                if (keyboard[Key.H])
                {
                    Console.Clear();
                    colorBlue_V2--;
                    Valori();
                }
            }
            else if (colorBlue_V2 <= 0)
            {
                if (keyboard[Key.G])
                {
                    Console.Clear();
                    colorBlue_V2++;
                    Valori();
                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////       VERTEX 3 //////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            if (colorRed_V3 < 255 && colorRed_V3 > 0)
            {
                if (keyboard[Key.Q])
                {
                    Console.Clear();
                    colorRed_V3++;
                    Valori();

                }
                else if (keyboard[Key.W])
                {
                    Console.Clear();
                    colorRed_V3--;
                    Valori();
                }
            }
            else if (colorRed_V3 >= 255)
            {
                if (keyboard[Key.W])
                {
                    Console.Clear();
                    colorRed_V3--;
                    Valori();
                }
            }
            else if (colorRed_V3 <= 0)
            {
                if (keyboard[Key.Q])
                {
                    Console.Clear();
                    colorRed_V3++;
                    Valori();
                }
            }



            if (colorGreen_V3 < 255 && colorGreen_V3 > 0)
            {
                if (keyboard[Key.E])
                {
                    Console.Clear();
                    colorGreen_V3++;
                    Valori();
                }
                else if (keyboard[Key.R])
                {
                    Console.Clear();
                    colorGreen_V3--;
                    Valori();
                }
            }
            else if (colorGreen_V3 >= 255)
            {
                if (keyboard[Key.R])
                {
                    Console.Clear();
                    colorGreen_V3--;
                    Valori();
                }
            }
            else if (colorGreen_V3 <= 0)
            {
                if (keyboard[Key.E])
                {
                    Console.Clear();
                    colorGreen_V3++;
                    Valori();
                }
            }



            if (colorBlue_V3 < 255 && colorBlue_V3 > 0)
            {
                if (keyboard[Key.T])
                {
                    Console.Clear();
                    colorBlue_V3++;
                    Valori();
                }
                else if (keyboard[Key.Y])
                {
                    Console.Clear();
                    colorBlue_V3--;
                    Valori();
                }
            }
            else if (colorBlue_V3 >= 255)
            {
                if (keyboard[Key.Y])
                {
                    Console.Clear();
                    colorBlue_V3--;
                    Valori();
                }
            }
            else if (colorBlue_V3 <= 0)
            {
                if (keyboard[Key.T])
                {
                    Console.Clear();
                    colorBlue_V3++;
                    Valori();
                }
            }
        }
    }
}

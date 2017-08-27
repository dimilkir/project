
namespace App10
{
    class KirkenBro
    {
        public void OpenBananaBox(BananaBox bananaBox, Dimka dimka)
        {
            Bananas bananas = bananaBox.Open();
            GetBananas(bananas, dimka);
        }

        virtual public void GetBananas(Bananas bananas, Dimka dimka)
        {
            dimka.ReceiveBananas(bananas);
        }
    }
}
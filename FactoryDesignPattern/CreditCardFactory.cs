namespace FactoryDesignPattern
{
    class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
           
            else
            {
                cardDetails = new Platinium();
            }

            return cardDetails;
        }
    }
}
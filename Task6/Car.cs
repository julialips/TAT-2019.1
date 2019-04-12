namespace Task6
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }

        /// <summary>
        /// Constructor of Auto.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="number"></param>
        /// <param name="price"></param>
        public Car(string brand, string model, int number, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Number = number;
            this.Price = price;
        }
    }
}

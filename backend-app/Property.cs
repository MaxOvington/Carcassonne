using System;

namespace Carcassonne {
    class Property {
        private long id;
        private string suburb;
        private string street;
        private int price;
        private int num_bedroom;
        private int num_bathroom;
        private int num_garage;

        public Property(long id, string suburb, string street, int price, int num_bedroom, int num_bathroom, int num_garage) {
            this.id = id;
            this.suburb = suburb;
            this.street = street;
            this.price = price;
            this.num_bedroom = num_bedroom;
            this.num_bathroom = num_bathroom;
            this.num_garage = num_garage;
        }

        public long Id { get {return id;} set{ id = value;} }
        public string Suburb { get {return suburb;} set{ suburb = value;} }
        public string Street { get {return street;} set{ street = value;} }
        public int Price { get {return price;} set{ price = value;} }
        public int Num_bedroom { get {return num_bedroom;} set{ num_bedroom = value;} }        
        public int Num_bathroom { get {return num_bathroom;} set{ num_bathroom = value;} }
        public int Num_garage { get {return num_garage;} set{ num_garage = value;} }
    }
}
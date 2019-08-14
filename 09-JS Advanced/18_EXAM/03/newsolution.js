class Hotel {
    constructor(name, capacity) {
        this.name = name,
            this.capacity = capacity,
            this.bookings = [],
            this.currentBookingNumber = 1
            this.single = Math.floor(this.capacity * 0.5),
            this.double = Math.floor(this.capacity * 0.3),
            this.maisonette = Math.floor(this.capacity * 0.2)
    }

    get roomsPricing() {
        return {
            single: 50,
            double: 90,
            maisonette: 135
        };
    }

    get servicesPricing() {
        return {
            food: 10,
            drink: 15,
            housekeeping: 25
        };
    }

    rentARoom(clientName, roomType, nights){
        if () {
            
        }
    }
}
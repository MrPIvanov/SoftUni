class Hotel {
    constructor(name, capacity) {
        this.name = name,
            this.capacity = capacity,
            this.bookings = [],
            this.currentBookingNumber = 1,

            this.availableRooms = {
                single: Math.floor(this.capacity * 0.5),
                double: Math.floor(this.capacity * 0.3),
                maisonette: Math.floor(this.capacity * 0.2)
            }
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

    rentARoom(clientName, roomType, nights) {

        let test = this.availableRooms[roomType];

        if (test <= 0) {

            if (roomType === 'single') {
                let temp = `No ${roomType} rooms available!`;

                if (this.availableRooms.double > 0) {
                    temp += ` Available double rooms: ${this.availableRooms.double}.`;
                }
                if (this.availableRooms.maisonette > 0) {
                    temp += ` Available maisonette rooms: ${this.availableRooms.maisonette}.`;
                }
                return temp;
            }

            if (roomType === 'double') {
                let temp = `No ${roomType} rooms available!`;

                if (this.availableRooms.single > 0) {
                    temp += ` Available single rooms: ${this.availableRooms.single}.`;
                }
                if (this.availableRooms.maisonette > 0) {
                    temp += ` Available maisonette rooms: ${this.availableRooms.maisonette}.`;
                }
                return temp;
            }

            if (roomType === 'maisonette') {
                let temp = `No ${roomType} rooms available!`;

                if (this.availableRooms.single > 0) {
                    temp += ` Available single rooms: ${this.availableRooms.single}.`;
                }
                if (this.availableRooms.double > 0) {
                    temp += ` Available double rooms: ${this.availableRooms.double}.`;
                }
                return temp;
            }

        }

        let result = {
            clientName: clientName,
            roomType: roomType,
            nights: nights,
            roomNumber: this.currentBookingNumber
        };

        this.bookings.push(result);
        this.currentBookingNumber++;
        this.availableRooms[roomType]--; //TO DO HERE

        return `Enjoy your time here Mr./Mrs. ${clientName}. Your booking is ${this.currentBookingNumber - 1}.`;

    }

    roomService(currentBookingNumber, serviceType) {
        //maybe ???
        let currentBooking = this.bookings.filter(function (el) {
            return el.roomNumber === currentBookingNumber;
        })[0];

        if (currentBooking === undefined) {
            return `The booking ${currentBookingNumber} is invalid.`;
        }

        // Invalid serviceType
        if (this.servicesPricing[serviceType] === undefined) {
            return `We do not offer ${serviceType} service.`;
        }
        if (!currentBooking.hasOwnProperty('services')) {
            currentBooking['services'] = [];
        }

        currentBooking.services.push(serviceType);

        return `Mr./Mrs. ${currentBooking.clientName}, Your order for ${serviceType} service has been successful.`;
    }

    checkOut(currentBookingNumber) {
        let currentBooking = this.bookings.filter(function (el) {
            return el.roomNumber === currentBookingNumber;
        })[0];

        if (currentBooking === undefined) {
            return `The booking ${currentBookingNumber} is invalid.`;
        }

        //remove room
        this.bookings = this.bookings.filter(function (el) {
            return el.roomNumber !== currentBookingNumber;
        });

        this.availableRooms[currentBooking.roomType]++;

        let nig = currentBooking.nights;

        let pri = this.roomsPricing[currentBooking.roomType];

        let totalPrice = currentBooking.nights * this.roomsPricing[currentBooking.roomType];

        this.availableRooms[currentBooking.roomType]++;

        // Maybe
        if (currentBooking.services === undefined) {
            return `We hope you enjoyed your time here, Mr./Mrs. ${currentBooking.clientName}. The total amount of money you have to pay is ${totalPrice} BGN.`;
        }

        let totalServiceMoney = 0;

        for (const serv of currentBooking.services) {
            totalServiceMoney += this.servicesPricing[serv]; // TO DO
        }

        return `We hope you enjoyed your time here, Mr./Mrs. ${currentBooking.clientName}. The total amount of money you have to pay is ${totalPrice + totalServiceMoney} BGN. You have used additional room services, costing ${totalServiceMoney} BGN.`;

    }

    report() {
        if (this.bookings.length <= 0) {
            return `${this.name.toUpperCase()} DATABASE:\n--------------------\nThere are currently no bookings.`;
        }

        let result = `${this.name.toUpperCase()} DATABASE:\n--------------------\n`;

        for (const room of this.bookings) {
            let temp = `bookingNumber - ${room.roomNumber}\nclientName - ${room.clientName}\nroomType - ${room.roomType}\nnights - ${room.nights}\n`;

            if (room.services !== undefined) {
                temp += `services: `;
                temp += room.services.join(', ');
                temp += '\n';
            }

            temp += '----------\n';

            result += temp;
        }

        result = result.substring(0, result.length - 12);
        return result;
    }
}

let hotel = new Hotel('HotUni', 10);

console.log(hotel.rentARoom('Peter', 'single', 4));
console.log(hotel.rentARoom('Robert', 'double', 4));
console.log(hotel.rentARoom('Geroge', 'maisonette', 6));


console.log(hotel.checkOut(2));

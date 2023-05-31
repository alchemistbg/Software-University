function solve(inputData, sortCriteria) {
    class Ticket {
        constructor(dest, price, status) {
            this.destination = dest;
            this.price = +price;
            this.status = status;
        }
    }
    let finalData = [];
    let rawData = inputData;
    rawData.forEach((x) => {
        let row = x.split('|');
        let ticket = new Ticket(row[0], row[1], row[2]);
        finalData.push(ticket);
    });

    finalData.sort((a, b) => {
        if (a[sortCriteria] > b[sortCriteria]){
            return 1;
        }
        if (a[sortCriteria] < b[sortCriteria]){
            return -1
        }
        return 0;
    });
    return finalData;
}


let data =
    ['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'];
let sort = 'destination';

console.log(solve(data, sort));;

// console.log(tickets.print());
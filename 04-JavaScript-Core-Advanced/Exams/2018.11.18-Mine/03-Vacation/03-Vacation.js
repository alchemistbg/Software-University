class Vacation {
    constructor(organizer, destination, budget) {
        this.organizer = organizer;
        this.destination = destination;
        this.budget = +budget;
        this.kids = {};
    }

    registerChild(name, grade, budget) {
        let kidBudget = +budget;
        if (kidBudget < this.budget) {
            return `${name}'s money is not enough to go on vacation to ${this.destination}.`;
        } else {

            if (!this.kids.hasOwnProperty(`${grade}`)) {
                this.kids[`${grade}`] = [];
            }

            if (this.kids[`${grade}`].includes(`${name}-${kidBudget}`)) {
                return `${name} is already in the list for this ${this.destination} vacation.`;
            }

            this.kids[`${grade}`].push(`${name}-${kidBudget}`);
            return this.kids[`${grade}`];
        }
    }

    removeChild(name, grade) {
        if (!this.kids.hasOwnProperty(`${grade}`)) {
            return `We couldn't find ${name} in ${grade} grade.`
        }

        let toRemove = -1;
        this.kids[`${grade}`].forEach((kid) => {
            toRemove++;
            if (kid.split('-')[0] === name) {
                console.log(toRemove)
                return;
            }
        });

        if (toRemove > -1) {
            return this.kids[`${grade}`].splice(toRemove, 1);
        } else {
            return `We couldn't find ${name} in ${grade} grade.`
        }

    }

    toString() {
        let info;
        let grades = Object.keys(this.kids);
        if (grades === undefined || grades.length === 0) {
            info = `No children are enrolled for the trip and the organization of ${this.organizer} falls out...`;
        } else {
            info = '';
            let numberOfChildren = 0;
            for (let grade of grades) {
                numberOfChildren += (this.kids[`${grade}`].length);
            }
            info += `${this.organizer} will take ${numberOfChildren} children on trip to ${this.destination}\n`;

            for (let grade of grades) {
                info += `Grade: ${grade}\n`;
                for (let i = 0; i < this.kids[grade].length; i++) {
                    info += `${i + 1}. ${this.kids[grade][i]}\n`;
                }
                info += '\n';
            }
        }
        return info;
    }
}

let vacation = new Vacation('Mr Pesho', 'San diego', 2000);
vacation.registerChild('Gosho', 5, 2000);
vacation.registerChild('Lilly', 6, 2100);

console.log(vacation.removeChild('Gosho', 9));

vacation.registerChild('Pesho', 6, 2400);
vacation.registerChild('Gosho', 5, 2000);

console.log(vacation.removeChild('Lilly', 6));
console.log(vacation.registerChild('Tanya', 5, 6000))

console.log(vacation.toString())
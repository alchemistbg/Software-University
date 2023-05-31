class LineManager {
    constructor(stops) {
        this.stops = stops;
        this._currentDelay = 0;
        this.currentStop = 0;
        this.duration = 0;
    }

    get stops() {
        return this._stops;
    }

    set stops(val) {
        val.forEach((stop) => {
            if (typeof stop.name !== 'string' || stop.name === '' ||
                typeof stop.timeToNext !== 'number' || stop.timeToNext < 0) {
                throw new Error('Invalid stop');
            }
        });
        this._stops = val;
    };

    get atDepot() {
        return this.currentStop === this.stops.length - 1;
        // if (this.nextStopName === 'At depot') {
        //     return true;
        // }
        // return false;
    }

    get nextStopName() {
        // if (this.currentStop === 0) {
        //     return this.stops[1].name;
        // }
        // if (this.currentStop === this.stops.length) {
        //     return 'At depot';
        // }
        if (this.atDepot){
            return 'At depot';
        }
        return this.stops[this.currentStop + 1].name;
    }

    get currentDelay() {
        return this._currentDelay;
    }

    arriveAtStop(minutes) {
        if (minutes < 0) {
            throw new Error('minutes cannot be negative');
        }
        if (this.atDepot) {
            throw new Error('last stop reached');
        }

        this.currentStop++;
        // if (this.currentStop + 1 < this.stops.length) {
        //     this._nextStopName = this.stops[this.currentStop + 1].name;
        // }else{
        //     this._nextStopName = 'At depot';
        // }
        this.duration += minutes;
        this._currentDelay += minutes - this.stops[this.currentStop - 1].timeToNext;

        return !this.atDepot
    }

    toString() {
        let info = 'Line summary\n';
        if (this.atDepot) {
            info += '- Course completed\n';
        } else {
            info += `- Next stop: ${this.nextStopName}\n`;
        }
        info += `- Stops covered: ${this.currentStop}\n`;
        info += `- Time on course: ${this.duration} minutes\n`;
        info += `- Delay: ${this.currentDelay} minutes`;
        return info;
    }
}

const man = new LineManager([
    {name: 'Depot', timeToNext: 4},
    {name: 'Romanian Embassy', timeToNext: 2},
    {name: 'TV Tower', timeToNext: 3},
    {name: 'Interpred', timeToNext: 4},
    {name: 'Dianabad', timeToNext: 2},
    {name: 'Depot', timeToNext: 0},
]);
console.log(man.toString());
man.arriveAtStop(4);
console.log(man.toString());
man.arriveAtStop(4);
console.log(man.toString());
man.arriveAtStop(4);
console.log(man.toString());
man.arriveAtStop(4);
console.log(man.toString());
man.arriveAtStop(4);
console.log(man.toString());
// man.arriveAtStop(4);
// Should throw an Error (minutes cannot be negative)
//man.arriveAtStop(-4);
// Should throw an Error (last stop reached)
//  man.arriveAtStop(4);

// const wrong = new LineManager([
//     { name: 'Stop', timeToNext: { wrong: 'Should be a number'} }
// ]);

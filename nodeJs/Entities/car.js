import {Vehicle} from './vehicle.js';

export class Car extends Vehicle {
    constructor(brand, model, doors, price) {
        super(brand, model, price);
        this._doors = doors;
    }

    get doors(){ return this._doors; }
    set doors(value){ this._doors = value; }

}

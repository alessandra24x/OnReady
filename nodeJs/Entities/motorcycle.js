import {Vehicle} from './vehicle.js';

export class Motorcycle extends Vehicle {
    constructor(brand, model, displacement, price) {
        super(brand, model, price);
        this._displacement = displacement;
    }

    get displacement(){ return this._displacement; }
    set displacement(value){ this._displacement = value; }
}

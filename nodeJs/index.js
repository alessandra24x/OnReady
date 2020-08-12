import {Car} from './Entities/car.js';
import {Motorcycle} from './Entities/motorcycle.js';
import {Dealership} from './Entities/dealership.js';

const dealership = new Dealership();
const auto1 = new Car("Peugeot", "206", 4, 200000.00);
const moto1 = new Motorcycle("Honda", "Titan", "125c", 60000.00);
const auto2 = new Car("Peugeot", "208", 5, 250000.00);
const moto2 = new Motorcycle("Yamaha", "YBR", "160c", 80500.50);

dealership.addData(auto1);
dealership.addData(moto1);
dealership.addData(auto2);
dealership.addData(moto2);

dealership.printVehicles();

console.log(Dealership.vehicleMostExpensive(dealership));
console.log(Dealership.vehicleMostCheap(dealership));
console.log(Dealership.modelWithLetter(dealership, "Y"));

dealership.sortVehiclesByPrice("ascend");
console.log(dealership.printOrderedVehicles());
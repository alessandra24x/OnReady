import {Car} from './car.js';
import {Motorcycle} from './motorcycle.js';

export class Dealership {
    constructor() {
        this.data = [];
    }

    addData(vehicle) {
        if(this.validateData() && !(this.data.includes(vehicle))) {
            this.data.push(vehicle);
        }
        return this.data;
    }

    printVehicles() {
        console.log(this.showData());
        console.log("=============================\n");
    }

    validateData() {
        if(this.data.length <= 0 || this.data == null)
            return false;
        else
            return true;
    }

    showData() {
        if(this.validateData()) {
            let result = '';
            this.data.forEach(item => {
            result += `Marca ${item.brand} // Modelo ${item.model} `;
                if(item instanceof Motorcycle) {
                    result += `// Cilindrada: ${item.displacement} `;
                } else {
                    result += `// Puertas: ${item.doors} `;
                }
                result += `// Precio $${item.price.toLocaleString("es", {style:'decimal', minimumFractionDigits: 2})}\n`;
            });
            return result;   
        } else
            return `No hay información para mostrar`;
    }

    static vehicleMostExpensive(dealership) {
        if(dealership.validateData()) {
            let maxPrice = dealership.data[0].price;
            let vehicleMostExpensive = dealership.data[0];
            dealership.data.forEach(vehicle => {
                if(vehicle.price > maxPrice) {
                    maxPrice = vehicle.price;
                    vehicleMostExpensive = vehicle;
                }
            });
            return `Vehiculo mas caro: ${vehicleMostExpensive.brand} ${vehicleMostExpensive.model}`;
        } else
            return `No hay información para mostrar`;
    }

    static vehicleMostCheap(dealership) {
        if(dealership.validateData()) {
            let minPrice = dealership.data[0].price;
            let vehicleMostCheap = dealership.data[0];
            dealership.data.forEach(vehicle => {
                if(vehicle.price < minPrice) {
                    minPrice = vehicle.price;
                    vehicleMostCheap = vehicle;
                }
            });
            return `Vehiculo mas barato: ${vehicleMostCheap.brand} ${vehicleMostCheap.model}`;
        } else
            return `No hay información para mostrar`;
    }

    static modelWithLetter(dealership, letter) {
        if(dealership.validateData()) {
            let lowerLetter = letter.toLowerCase();
            let modelWithLetter = null;
            dealership.data.forEach(vehicle => {
                let aux = vehicle.model.toLowerCase();
                if(aux.includes(lowerLetter)) {
                    modelWithLetter = vehicle;
                }
            });    
            return `Vehículo que contiene en el modelo la letra ‘${letter}’: ${modelWithLetter.brand} ${modelWithLetter.model} ${modelWithLetter.price.toLocaleString("es", {style:'decimal', minimumFractionDigits: 2})}`;
        } else
            return `No hay información para mostrar`;
    }

    sortVehiclesByPrice(criterion) {
        if(typeof criterion === "string") {
            criterion = criterion.trim().toLowerCase();
            if(criterion === "ascend") {
                this.data.sort((a,b) => b.price-a.price);
            } else if(criterion === "descendant") {
                this.data.sort((a,b) => a.price-b.price);
            } else {
                throw new Error("No se ha recibido un criterio de ordenamiento válido");
            }
        }
    }

    printOrderedVehicles() {
        if(dealership.validateData()) {
            console.log("\n=============================\n");
            console.log("Vehículos ordenados por precio de mayor a menor:");
            let result = '';
            this.data.forEach(vehicle => {
                result += `${vehicle.brand} ${vehicle.model}\n`;
            });    
            return result;
        } else
            return `No hay información para mostrar`;
    }

}
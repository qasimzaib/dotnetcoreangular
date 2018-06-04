import { ManufacturerService } from './../../services/manufacturer.service';
import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'app-vehicle-form',
	templateUrl: './vehicle-form.component.html',
	styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
	manufacturers: any[];
	models: any[];
	vehicle: any = {};

	constructor(private manufacturerService :ManufacturerService) { }

	ngOnInit() {
		this.manufacturerService.getManufacturers()
			.subscribe(m => this.manufacturers = m);
	}

	onManufacturerChange() {
		var selectedManufacturer = this.manufacturers.find(m => m.id == this.vehicle.manufacturer)
		this.models = selectedManufacturer ? selectedManufacturer.models : [];
	}
}
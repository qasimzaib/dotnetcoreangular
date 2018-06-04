import { ManufacturerService } from './../../services/manufacturer.service';
import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'app-vehicle-form',
	templateUrl: './vehicle-form.component.html',
	styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
	manufacturers: any;

	constructor(private manufacturerService :ManufacturerService) { }

	ngOnInit() {
		this.manufacturerService.getManufacturers()
			.subscribe(m => {
				console.log(m);
				this.manufacturers = m;
				console.log("M", this.manufacturers);
			}
		);
	}
}
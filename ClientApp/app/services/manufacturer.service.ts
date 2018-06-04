import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()

export class ManufacturerService {
	constructor(private http: Http) { }

	getManufacturers () {
		return this.http.get('api/manufacturers')
			.map(response => response.json());
	}
}
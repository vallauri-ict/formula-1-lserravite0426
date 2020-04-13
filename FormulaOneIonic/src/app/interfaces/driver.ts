import { Country } from './country';

export interface Driver {
	id?: number;
	firstname?: string;
	lastname?: string;
	dob?: string;
	placeOfBirth?: string;
	country?: Country;
	img?: string;
	description?: string;
}

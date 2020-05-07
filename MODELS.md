# Models
Here you can find the DB's table models.

## Countries
| field			| type      	| null?	| key	| default	|
|---------------|---------------|-------|-------|-----------|
| countryCode	| char(2)		| NO	| PK	|			|
| countryName	| varchar(100)	| NO	|		|			|

## Drivers
| field        	| type			| null? | key	| default	|
|---------------|---------------|-------|-------|-----------|
| id			| int			| NO	| PK	|			|
| firstname		| varchar(128)	| NO	|		|			|
| lastname		| varchar(128)	| NO	|		|			|
| dob			| date			| NO	|		|			|
| img			| varchar(512)	| NO	|		|			|
| description	| varchar(4096)	| NO	|		|			|
| extCountry	| char(2)		| NO	| FK	|			|

## Teams
| field				| type			| null?	| key	| default	|
|-------------------|---------------|-------|-------|-----------|
| id				| int			| NO	| PK	|			|
| name				| varchar(128)	| NO	|		|			|
| fullTeamName		| varchar(128)	| NO	|		|			|
| powerUnit			| varchar(128)	| NO	|		|			|
| technicalChief	| varchar(128)	| NO	|		|			| 
| chassis			| varchar(128)	| NO	|		|			|
| logo				| varchar(512)	| NO	|		|			|
| img				| varchar(512)	| NO	|		|			|
| extCountry		| char(2)		| NO	| FK	|			|
| extFirstDriver	| int			| NO	| FK	|			|
| extSecondDriver	| int			| NO	| FK	|			|

## Circuits
| field			| type			| null?	| key	| default	|
|---------------|---------------|-------|-------|-----------|
| id			| int			| NO	| PK	|			|
| name			| varchar(256)	| NO	|		|			|
| length		| int			| NO	|		|			|
| nLaps			| int			| NO	|		|			|
| recordlap		| int			| NO	|		| NULL		|
| img			| varchar(512)	| NO	|		|			|
| extCountry	| char(2)		| NO	| FK	|			|

## Races
| field			| type			| null? | key | default |
|---------------|---------------|-------|-----|---------|
| id		 	| int			| NO	| PK  |			|
| name			| varchar(128)	| NO	|     |			|
| date			| date			| NO	|     |			|
| extCircuit	| int(11)		| NO	| FK  |			|

## Scores
| field		| type			| null? | key | default |
|-----------|---------------|-------|-----|---------|
| pos		| int			| NO	| PK  |			|
| score		| int			| NO	|     |			|
| details	| varchar(128)	| NO	|     |			|

## Races_Scores
| field		| type			| null? | key		| default	|
|-----------|---------------|-------|-----------|-----------|
| extDriver	| int			| NO	| PK, FK	|			|
| extRace	| int			| YES	| PK, FK	|	NULL	|
| extPos	| int			| NO	| FK  		|			|
| fastesLap	| varchar(30)	| NO	|			|			|
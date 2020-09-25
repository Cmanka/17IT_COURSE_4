function getWeek() {
	let year = Number(document.form1.year.value);
	let month = Number(document.form1.month.value);
	let day = Number(document.form1.day.value);
	const result = document.form1.result;

	day = new Date(year, month - 1, day);
	month = new Date(year, 0, 1).getTime();
	year = [7, 1, 2, 3, 4, 5, 6][day.getDay()];
	day = day.getTime();

	result.value = 1 + Math.ceil(((day - month) / 36e5 / 24 - year) / 7);
}

class Zodiac {
	constructor(name, dayS, monthS, dayE, monthE) {
		this.name = name;
		this.start = {
			day: dayS,
			month: monthS,
		};
		this.end = {
			day: dayE,
			month: monthE,
		};
	}
}

function getZodiac() {
	const month = Number(document.form2.month.value);
	const day = Number(document.form2.day.value);
	const result = document.form2.result;

	if (!day || !month) {
		alert("Enter date");
		result.value = "";
		return;
	}
	if (day <= 0 || day > 31 || month <= 0 || month > 12) {
		alert("Enter correct date");
		result.value = "";
		return;
	}

	const zodiacs = [
		new Zodiac("Kozerog", 23, 12, 20, 1),
		new Zodiac("Vodoley", 21, 1, 19, 2),
		new Zodiac("Riba", 20, 23, 20, 3),
		new Zodiac("Oven", 21, 3, 20, 4),
		new Zodiac("Telec", 21, 4, 21, 5),
		new Zodiac("Blizneci", 22, 5, 21, 6),
		new Zodiac("Rak", 22, 6, 22, 7),
		new Zodiac("Lev", 23, 7, 21, 8),
		new Zodiac("Deva", 22, 8, 23, 9),
		new Zodiac("Veci", 24, 9, 23, 10),
		new Zodiac("Skorpion", 24, 10, 22, 11),
		new Zodiac("Strelec", 23, 11, 22, 12),
	];

	for (let i = 0; i < zodiacs.length; i++) {
		let zodiac = zodiacs[i];
		if (
			(zodiac.start.month == month && zodiac.start.day <= day) ||
			(zodiac.end.month == month && zodiac.end.day >= day)
		) {
			result.value = zodiac.name;
		}
	}
}

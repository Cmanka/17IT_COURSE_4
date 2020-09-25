function calculateMaxValue(form) {
	const v1 = Number(form.v1.value);
	const v2 = Number(form.v2.value);
	const v3 = Number(form.v3.value);
	const v4 = Number(form.v4.value);
	const v5 = Number(form.v5.value);

	form.result.value = Math.max(Math.max(v1, v2), Math.max(v3, v4), v5);
}

function isTriangle(form) {
	const a = form.firstSide.value;
	const b = form.secondSide.value;
	const c = form.thirdSide.value;

	if (a + b > c && a + c > b && b + c > a) {
		form.result.value = "Might";
		return true;
	}

	form.result.value = "Cannot";
	return false;
}

function calcQuarter(form) {
	const x = form.x.value;
	const y = form.y.value;
	let res = form.result;

	if (x > 0 && y > 0) res.value = 1;
	else if (x < 0 && y > 0) res.value = 2;
	else if (x < 0 && y < 0) res.value = 3;
	else if (x > 0 && y < 0) res.value = 4;
	else alert("Enter values");
}

function getValues() {
	const pdiTime = Number(document.form.pdiTime.value);
	const pdiLang = Number(document.form.pdiLang.value);
	const pdiResult = document.form.pdiPrice;

	pdiResult.value = (pdiTime + pdiLang) * 2;

	const rkppTime = Number(document.form.rkppTime.value);
	const rkppLang = Number(document.form.rkppLang.value);
	const rkppResult = document.form.rkppPrice;

	rkppResult.value = (rkppTime + rkppLang) * 2;

	const bdTime = Number(document.form.bdTime.value);
	const bdLang = Number(document.form.bdLang.value);
	const bdResult = document.form.bdPrice;

	bdResult.value = (bdTime + bdLang) * 2;

	const pmsTime = Number(document.form.pmsTime.value);
	const pmsLang = Number(document.form.pmsLang.value);
	const pmsResult = document.form.pmsPrice;

	pmsResult.value = (pmsTime + pmsLang) * 2;
}

function calculatePrice() {
	if (!userForm.name.value || !userForm.email.value || !userForm.age.value) {
		alert("Enter personal info");
		return;
	}
	const priceTable = {
		things: document.form.thing,
		thingResult: [
			Number(document.form.pdiPrice.value),
			Number(document.form.rkppPrice.value),
			Number(document.form.bdPrice.value),
			Number(document.form.pmsPrice.value),
		],
	};
	const resultArr = [];
	const pageResult = document.form.result;

	for (let i = 0; i < priceTable.things.length; i++) {
		if (priceTable.things[i].checked) {
			resultArr.push(Number(priceTable.things[i].value) + priceTable.thingResult[i]);
		}
	}

	let result = 0;
	resultArr.forEach((number) => {
		result += number;
	});

	pageResult.value = result;
}

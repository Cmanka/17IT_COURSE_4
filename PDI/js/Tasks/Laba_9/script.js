function reverseNumber(field) {
	let arr = field.value.split("");
	for (let i = 0, j = arr.length - 1; i < j; i++, j--) {
		let tmp = arr[j];
		arr[j] = arr[i];
		arr[i] = tmp;
	}
	field.value = arr.join("");
}

function isLuckyNumber() {
	const number = document.form2.number;
	const resultField = document.form2.result;
	if (!number || number.value.length != 6) {
		alert("check your number");
		return;
	}

	const arr = number.value.split("");
	let half1 = 0;
	let half2 = 0;
	for (let i = 0, j = arr.length - 1; i < j; i++, j--) {
		half1 += Number(arr[i]);
		half2 += Number(arr[j]);
	}
	if (half1 === half2) {
		resultField.value = "Yes";
		return true;
	}
	resultField.value = "No";
	return false;
}

function divNum() {
	const number = Number(document.form3.number.value);
	const result = document.form3.result;
	let arr = [1];
	for (let i = 2; i <= number; i++) {
		if (number % i === 0) arr.push(i);
	}
	result.value = arr;
}

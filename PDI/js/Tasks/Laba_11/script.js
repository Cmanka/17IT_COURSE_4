function getCountOfWords() {
	const str = document.form1.str.value;
	const result = document.form1.result;
	const strArr = str.split(" ");
	let countOfWords = 0;
	for (let i = 0; i < strArr.length; i++) {
		if (strArr[i]) countOfWords++;
	}
	result.value = countOfWords;
}

function replaceWords() {
	const text = document.form2.text.value;
	const str1 = document.form2.str1.value;
	const str2 = document.form2.str2.value;
	const result = document.form2.result;

	result.value = text.replace(new RegExp(str1, "g"), str2);
}

function compressSpaces() {
	const text = document.form3.text.value;
	const result = document.form3.result;

	result.value = text.replace(/\s+/g, " ").trim();
}

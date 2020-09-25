function watchCartoon() {
	imgArray = new Array();
	for (let i = 0; i < 6; i++) {
		imgArray[i] = new Image(50, 100);
	}

	imgArray[0].src = "img/1";
	imgArray[1].src = "img/2";
	imgArray[2].src = "img/3";
	imgArray[3].src = "img/4";
	imgArray[4].src = "img/5";
	imgArray[5].src = "img/6";
	p = -1;
}

function onCartoon() {
	p = p + 1;
	document.images[0].src = imgArray[p].src;
	setTimeout("onCartoon()", 100);
	if (p === 5) p = -1;
}

function getPositiveElements() {
	const fieldArr = document.form1.array;
	const result = document.form1.result;
	const arr = fieldArr.value.split(" ");
	const resultArr = [];
	for (let i = 0; i < arr.length; i++) {
		if (arr[i] > 0) resultArr.push(arr[i]);
	}

	result.value = resultArr;
}

function getMaxElement() {
	const fieldArr = document.form2.array;
	const arr = fieldArr.value.split(" ");
	const result = document.form2.result;

	result.value = Math.max.apply(null, arr);
}

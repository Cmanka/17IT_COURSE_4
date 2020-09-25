function getData() {
	let aX = document.getElementById("Ax").value;
	let aY = document.getElementById("Ay").value;
	let bX = document.getElementById("Bx").value;
	let bY = document.getElementById("By").value;
	let cX = document.getElementById("Cx").value;
	let cY = document.getElementById("Cy").value;
	document.getElementById("result").innerText = getSquare(aX, aY, bX, bY, cX, cY);
}

function getSquare(aX, aY, bX, bY, cX, cY) {
	return Math.abs(aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2;
}

function calculateRange(form) {
	const x = Number(form.x.value);
	const y = Number(form.y.value);
	form.result.value = Math.sqrt(x ** 2 + y ** 2);
}

function replaceValues(obj) {
	const tmp = obj.firstValue.value;
	obj.firstValue.value = obj.secondValue.value;
	obj.secondValue.value = tmp;
}

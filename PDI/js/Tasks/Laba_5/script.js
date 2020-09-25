function changeHrTag(form) {
	const sizeP = form.elements[0];
	const sizeM = form.elements[1];
	const alignL = form.elements[2];
	const alignR = form.elements[3];
	const hr = document.getElementById("hr");

	if (sizeP.checked) {
		hr.style.height = "30px";
	}
	if (sizeM.checked) {
		hr.style.height = "5px";
	}
	if (alignL.checked) {
		hr.setAttribute("align", "left");
	}
	if (alignR.checked) {
		hr.setAttribute("align", "right");
	}
}

function resetHrTag() {
	const hr = document.getElementById("hr");
	hr.style.height = "15px";
	hr.setAttribute("align", "center");
}

function sendForm(form) {
	const firstName = form.firstName.value;
	const lastName = form.lastName.value;
	const sex = form.sex.value;
	const age = form.age.value;
	const status = form.status.value;

	if (!firstName || !lastName || !sex || !age || !status) {
		alert("Empty field");
		return;
	}

	alert(`First name:${firstName}\nLast name:${lastName}\nSex:${sex}\nAge:${age}\nStatus:${status}`);
}

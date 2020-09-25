function setTableColor(color) {
	const table = document.querySelector("table");
	switch (color) {
		case "red": {
			table.style.backgroundColor = "red";
			break;
		}
		case "green": {
			table.style.backgroundColor = "green";
			break;
		}
		case "blue": {
			table.style.backgroundColor = "blue";
			break;
		}
		case "img": {
			table.style.backgroundImage = "url(img/1)";
			break;
		}
	}
}

function setFieldColor(fieldId, color) {
	const field = document.getElementById(fieldId);
	if (color === "img") {
		field.style.backgroundImage = "url(img/1)";
	}
	field.style.backgroundColor = color;
}

function calculateOrder(form) {
	const item = form.items.value;
	const count = form.itemsCount.value;
	const price = form.itemPrice.value;

	alert(`item:${item}\ncount:${count}\nprice:${price}\nresult:${count * price}`);
}

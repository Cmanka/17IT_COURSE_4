let check = false;
function pickImg(form) {
	const content = document.querySelector(".images");
	const pickedImg = form.pickedImg.value;
	if (pickedImg === "1") createImage(document.images[3], pickedImg);
	else if (pickedImg === "2") createImage(document.images[3], pickedImg);
	else if (pickedImg === "3") createImage(document.images[3], pickedImg);
	else alert("Enter image");
}

function createImage(img, number) {
	img.src = `img/${number}`;

	return img;
}

function onOver() {
	const img = document.getElementById("sTask");

	img.style.width = "600px";
}

function onOut() {
	const img = document.getElementById("sTask");

	img.style.width = "400px";
}

window.onload = selectedLi();

function selectedLi() {
	const list = document.getElementsByTagName("li");

	for (let i = 0; i < list.length; i++) {
		list[i].onmouseover = () => {
			list[i].style.border = "1px solid black";
		};
		list[i].onmouseout = () => {
			list[i].style.border = "none";
		};
	}
}

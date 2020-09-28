<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />
		<title>Document</title>
		<link rel="stylesheet" href="style.css" />
	</head>
	<body align="center">
		<header>
			<ul type="none" class="inline">
				<li>Войти |</li>
				<a href="newnote.php"><li>Новая запись |</li></a>
				<a href="email.php"><li>Отправить сообщение |</li></a>
				<li>Фото |</li>
				<li>Файлы |</li>
				<li>Администратору |</li>
				<a href="inform.php"><li>Информация |</li></a>
				<li>Выйти</li>
			</ul>
			<hr />
		</header>
		<div>
			<p>
				Рад приветстововать <br />
				вас на страницах моего сайта, посвященного путешествиям <br />
				Здесь я буду рассказывать о своих путешествиях... <br />
				.... и выкладывать разные инетресные материалы!
			</p>
		</div>
	</body>
</html>

<?php
require_once("MySiteDB.php");

$select = mysqli_select_db($link,$db);
$query = "SELECT * FROM `notes` ORDER BY id DESC";
$result = mysqli_query($link,$query);

while($note = mysqli_fetch_array($result)){
  echo $note ['id'],"<br/>";
?>
<a href="comments.php?note=<?php echo $note['id'];?>">
<?php echo $note ['title'],"<br/>";?></a>
<?php
echo $note ['article'],"<br/>";
echo $note ['created'],"<br/>";
}
?>
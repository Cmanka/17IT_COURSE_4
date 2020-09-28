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
				<a href="photo.php"><li>Фото |</li></a>
				<a href="files.php"><li>Файлы |</li></a>
				<li>Администратору |</li>
				<a href="inform.php"><li>Информация |</li></a>
				<li>Выйти</li>
			</ul>
			<form action="search.php" class='search_panel' method="post" name="search">
				<input type="search" name='query' placeholder="поиск">
				<button type='submit'>Найти</button>
			</form>
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